# Frends.Community.AesCtrCalculator

FRENDS community task for calculating AES CTR. http://www.cryptogrium.com/aes-ctr.html


[![Actions Status](https://github.com/CommunityHiQ/Frends.Community.AesCtrCalculator/workflows/PackAndPushAfterMerge/badge.svg)](https://github.com/CommunityHiQ/Frends.Community.AesCtrCalculator/actions) ![MyGet](https://img.shields.io/myget/frends-community/v/Frends.Community.AesCtrCalculator) [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT) 

- [Installing](#installing)
- [Tasks](#tasks)
  - [CalculateAesCtr](#calculateaesctr)
    - [Input](#input)
    - [Output](#output)
- [Building](#building)
- [Contributing](#contributing)
- [Change Log](#change-log)

# Installing

You can install the Task via frends UI Task View or you can find the NuGet package from the following NuGet feed
https://www.myget.org/F/frends-community/api/v3/index.json and in Gallery view in MyGet https://www.myget.org/feed/frends-community/package/nuget/Frends.Community.AesCtrCalculator

# Tasks

## CalculateAesCtr

Calculate AES CTR with given inputs.

### Input

| Property | Type | Description | Example |
| ---------|------|-------------|---------|
| Data | String | Data in hex format | 1af1ae9ba7cfda4c84d6 |
| Key | String | Key in hex format | 110BFE1B1116085EB5611152E5244FF5 |
| Iv | String | Iv in hex format | 1c1c1c1c1c1c1c1c1c1c1c1c1c1c1c1c |

### Output

| Property | Type | Description | Example |
| ---------|------|-------------|---------|
| Data | String | Data in hex format | A7837045760FDAD82C0D |

# Building

Clone a copy of the repository

`git clone https://github.com/CommunityHiQ/Frends.Community.AesCtrCalculator.git`

Rebuild the project

`dotnet build`

Run tests

`dotnet test`

Create a NuGet package

`dotnet pack --configuration Release`

# Contributing
When contributing to this repository, please first discuss the change you wish to make via issue, email, or any other method with the owners of this repository before making a change.

1. Fork the repository on GitHub
2. Clone the project to your own machine
3. Commit changes to your own branch
4. Push your work back up to your fork
5. Submit a Pull request so that we can review your changes

NOTE: Be sure to merge the latest from "upstream" before making a pull request!

# Change Log

| Version | Changes |
| ----- | ----- |
| 1.0.0 | Initial version of AesCtrCalculator Task |
| 1.1.0 | Fixed missing descriptions in Task |
| 1.2.0 | Converted to support .Net Framework 4.7.1 and .Net Standard 2.0 |
| 2.0.0 | Targeted to .NET6 and .NET8, and updated System.ComponentModel.Annotations to 5.0.0 |
