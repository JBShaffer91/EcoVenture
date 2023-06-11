# EcoVenture

## Project Description

EcoVenture is an application designed to assist outdoor adventurers with planning for their expeditions. The application provides recommendations for packing lists based on the location, season, and predicted weather. It also offers product recommendations to enhance the outdoor experience.

## Getting Started

### Dependencies

* .NET 7.0
* Entity Framework Core
* MySQL Server 8.0.33

### Installing

* Clone the repository: `git clone https://github.com/JBShaffer91/EcoVenture.git`
* Navigate into the project directory: `cd ecoventure`
* Restore packages: `dotnet restore`

### Executing program

* Run the program: `dotnet run`

## Features

### Locations

* Get all locations: `GET /api/locations`
* Get a specific location: `GET /api/locations/{id}`
* Add a new location: `POST /api/locations`
* Update a location: `PUT /api/locations/{id}`
* Delete a location: `DELETE /api/locations/{id}`

### Packing Lists

* Get all packing lists: `GET /api/packinglists`
* Get a specific packing list: `GET /api/packinglists/{id}`
* Add a new packing list: `POST /api/packinglists`
* Update a packing list: `PUT /api/packinglists/{id}`
* Delete a packing list: `DELETE /api/packinglists/{id}`

### Product Recommendations

* Get all product recommendations: `GET /api/productrecommendations`
* Get a specific product recommendation: `GET /api/productrecommendations/{id}`
* Add a new product recommendation: `POST /api/productrecommendations`
* Update a product recommendation: `PUT /api/productrecommendations/{id}`
* Delete a product recommendation: `DELETE /api/productrecommendations/{id}`

## Help

If you encounter any problems, please open an issue on the GitHub repository.

## Authors

Justin Shaffer
justinbshaffer91@gmail.com

## Version History

* 0.1
    * Initial release with Locations, Packing Lists, and Product Recommendations controllers

## License

Copyright 2023 Justin Shaffer

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
