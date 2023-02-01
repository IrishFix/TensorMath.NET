﻿# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [0.3.0] - 2023-02-01

### Added

- Random.cs to handle cases of generating random point clouds and will contain more in the future.

## [0.2.2] - 2023-02-01

### Changed

- Removed problematic .meta files.

## [0.2.1] - 2023-01-31

### Changed

- CHANGELOG.md to include github diffs at page bottom.

## [0.2.0] - 2023-01-31

### Removed

- Conversion.cs, as its functionality is already offered better by Extensions.cs.

## [0.1.1] - 2023-01-31

### Added

- Description for package.json.

### Changed

- Name for package.json.
- Internal definitions to public for use outside of the packages cs assembly.
- 'ComputationalGeometry.Runtime' namespace to just 'ComputationalGeometry' as it simplifies the 'using' statement when referencing this package in unity projects.

## [0.1.0] - 2023-01-31

### Added

- Edge2D.cs, its constructor(s), and all related methods.
- Edge3D.cs, its constructor(s), and all related methods.
- Triangle2D.cs, its constructor(s), and all related methods.
- Triangle3D.cs, its constructor(s), and all related methods.
- Extensions.cs, to allow swift conversions between Vector types and all types above.
- Intersection.cs, for detecting intersections / overlaps between listed geometries.
- PointComputations.cs, to facilitate convex hull computation, point cloud simplification, and continuing on, any solely point-based methods.
- Conversion.cs, to allow conversion of Vector types.

[unreleased]: https://github.com/IrishFix/Computational-Geometry/compare/v0.3.0...HEAD
[0.3.0]: https://github.com/IrishFix/Computational-Geometry/compare/v0.2.2...v0.3.0
[0.2.2]: https://github.com/IrishFix/Computational-Geometry/compare/v0.2.1...v0.2.2
[0.2.1]: https://github.com/IrishFix/Computational-Geometry/compare/v0.2.0...v0.2.1
[0.2.0]: https://github.com/IrishFix/Computational-Geometry/compare/v0.1.1...v0.2.0
[0.1.1]: https://github.com/IrishFix/Computational-Geometry/compare/v0.1.0...v0.1.1
[0.1.0]: https://github.com/IrishFix/Computational-Geometry/releases/tag/v0.1.0