<<<<<<< development
﻿window.map = null;

window.initMap = function (lat, lon) {

    window.map = L.map('map').setView([lat, lon], 13);

    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        attribution: '© OpenStreetMap contributors'
    }).addTo(window.map);

    L.marker([lat, lon]).addTo(window.map);
};

window.addMarker = function (lat, lon, type, tags) {

    if (!window.map) {
        console.error("Map not initialized!");
        return;
    }

    // Dictionary/Objekt zu HTML-Liste formatieren
    let tagsHtml = '';
    if (tags && typeof tags === 'object' && Object.keys(tags).length > 0) {
        tagsHtml = '<strong>Tags:</strong><ul style="margin: 5px 0; padding-left: 20px;">';
        for (const [key, value] of Object.entries(tags)) {
            tagsHtml += `<li><strong>${key}:</strong> ${value}</li>`;
        }
        tagsHtml += '</ul>';
    } else {
        tagsHtml = '<em>Keine Tags verfügbar</em>';
    }

    L.marker([lat, lon]).addTo(window.map)
        .bindPopup(`<strong>Type:</strong> ${type}<br>${tagsHtml}`);
};
=======
﻿function initMap(lat, lon) {
    const map = L.map('map').setView([lat, lon], 13);

    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        attribution: '© OpenStreetMap contributors'
    }).addTo(map);

    L.marker([lat, lon]).addTo(map)
        .bindPopup(`Lat: ${lat}<br>Lon: ${lon}`)
        .openPopup();
}
>>>>>>> master
