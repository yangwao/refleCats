# :cat: RefleCats
b/c reflections mattersヽ(^‥^=ゞ)

repository for [Copernicus hackathon](copernicus.devpost.com) held 4-5/11/2016 in Vienna, Austria

~~[Concept (SK)](https://github.com/yangwao/reflecats/wiki/Concept)~~

[Presentation](https://github.com/yangwao/reflecats/wiki/Presentation)

# Authors

* [Michal Dolnik](https://github.com/michaelknave)
* [Martin Fridrich](https://github.com/martinfridrich)
* [Matej Nemček](https://github.com/yangwao)
* [Ivana Zemanovicova](https://github.com/Ivkaa)

### Setup
before first pull you need [Git LFS](https://git-lfs.github.com/) installed (b/c tif)
```
brew install git-lfs
git lfs install
```
Query hints for [scihub](https://scihub.copernicus.eu/dhus/)
* Linz S2A_OPER_PRD_MSIL1C_PDMC swaths
  ```
  platformname:Sentinel-2 footprint:"intersects(48.2949799,14.1873221)"
  ```
  dataset
  >  S2A_OPER_PRD_MSIL1C_PDMC_20160915T180457_R122_V20160913T100022_20160913T100504

* Vienna S2A_OPER_PRD_MSIL1C_PDMC swaths
  ```
  platformname:Sentinel-2 footprint:"intersects(48.2082,16.3738)"
  ```
  dataset
  > S2A_OPER_PRD_MSIL1C_PDMC_20160915T180457_R122_V20160913T100022_20160913T100504

[Rest of knowledge is at our wiki](https://github.com/yangwao/reflecats/wiki/RefleCats)

## Technology Part

### Data acquisition

At [Scihub](https://scihub.copernicus.eu/dhus/) we used query for Vienna
```
platformname:Sentinel-2 footprint:"intersects(48.2082,16.3738)"
```

to get proper file names of data from Sentinel 2, which we unziped and loaded into qGIS

### Data processing

[Convert Landsat DNs to albedo](http://yceo.yale.edu/how-convert-landsat-dns-albedo)
![img](http://yceo.yale.edu/sites/default/files/images/AlbedoForm.PNG)

i.e. use this formula can be implemented in ENVI using Band Math as:
```
((0.356*B1) + (0.130*B2) + (0.373*B3) + (0.085*B4) + (0.072*B5) -0.018) / 1.016
```

We know that calculation of Albedo is hard thing in this industry

### Web

* Leaflet
* …

### Mobile

* Xamarin
* Mapbox
* …
