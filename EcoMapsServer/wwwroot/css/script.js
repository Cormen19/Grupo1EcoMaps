function initialize() {
    mapboxgl.accessToken ='pk.eyJ1IjoiYWdhcmNpYWVsbyIsImEiOiJjbGhrOGhpczUwcGpzM2hvZWJ5am9td29wIn0.jL8YC0Objqx0wc2g7bkBMA';
    var map = new mapboxgl.Map({
        container: 'map',
        style: 'mapbox://styles/mapbox/streets-v11',
        center: [-2.96476, 43.28475], // Longitude, Latitude
        zoom: 12
    });

    var element = document.createElement('div');
    element.className = 'marker';
    element.addEventListener('click', () => { window.alert('diste click') }); 
    var marcador = new mapboxgl.Marker(element).setLngLat({ lng: -2.96476, lat: 43.28475 }).addTo(map);
    
}