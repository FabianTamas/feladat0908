# Játékprogram - (Kő, Papír, Olló)

## Játékmenet 1.0
- [x] A számítógép választ egy lehetőséget
- [x] A felhasználó megad egy lehetőséget
- Nyerés:
	- Kő legyőzi az Ollót
	- Papír legyőzi a Követ
	- Olló legyőzi a Papírt

	[x] A nyerés megállapítását kiszervezzük metódusba
	- EmberNyer()
    - Visszaadott érték -> 0, 1, 2
    - 0: Döntetlen
    - 1: Gép nyer
    - 2: Ember nyer
- [x] Kiírjuk az eredményt
	- Kiírás külön metódusban

## Játékmenet 2.0
- [x] Addig játszunk amíg ki nem lépünk a játékból
- [x] Statisztika megvalósítása
	- gép, játékos, mennyi menet
- [] Eredmények fájlba írása és megjelenítése
    -  1. érték -> menet
    -  2. érték -> Játékos
    -  3. érték -> Gép
    - értékek ';'-vel elválasztva