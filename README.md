# Frends.Community.AesCtrCalculator

FRENDS community task for calculating AES CTR. http://www.cryptogrium.com/aes-ctr.html

- [Installing](#installing)
- [Tasks](#tasks)
  - [CalculateAesCtr](#calculateaesctr)
    - [Input](#input)
    - [Output](#output)
- [Building](#building)
- [Contributing](#contributing)
- [Change Log](#change-log)

# Installing

You can install the task via FRENDS UI Task View or you can find the nuget package from the following nuget feed.
'Insert nuget feed here'

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
Clone a copy of the repo

`git clone https://github.com/CommunityHiQ/Frends.Community.AesCtrCalculator`

Restore dependencies

`nuget restore frends.community.AesCtrCalculator`

Rebuild the project

Run unit tests

Create a nuget package

`nuget pack Frends.Community.AesCtrCalculator.nuspec`

# Contributing
When contributing to this repository, please first discuss the change you wish to make via issue, email, or any other method with the owners of this repository before making a change.

1. Fork the repo on GitHub
2. Clone the project to your own machine
3. Commit changes to your own branch
4. Push your work back up to your fork
5. Submit a Pull request so that we can review your changes

NOTE: Be sure to merge the latest from "upstream" before making a pull request!

# Change Log

| Version | Changes |
| ----- | ----- |
| 1.0.0 | Initial version of AesCtrCalculator Task |
