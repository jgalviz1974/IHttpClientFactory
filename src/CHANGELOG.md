# Changelog - Gasolutions.Core.Interfaces.RefitHttpClient

All notable changes to this project will be documented in this file.

## [1.0.8.2]
### Changed	
- The namespace in IHttpClientFactory{T}.cs is corrected to align with the correct convention deleting Refit word.

## [1.0.8.1]
### Changed	
- Nuget package name was changed from Gasolutions.Core.Interfaces.RefitHttpClient to Gasolutions.Core.Interfaces.HttpClient to better reflect the project purpose and improve discoverability

## [1.0.8]
### Added	
- Add CHANGELOG.md file to document changes and updates

## [1.0.7]

### Added
- Comprehensive XML documentation for all factory interfaces
- Enhanced factory pattern interfaces for client creation
- Support for advanced configuration options
- Builder pattern support for HTTP client setup
- Configuration interfaces for flexible client management

### Changed
- Updated Title and Description to English
- Improved API clarity and consistency
- Enhanced type safety with better generic constraints

### Fixed
- Factory method parameter handling
- Client creation validation improvements

### Documentation
- Added comprehensive XML documentation for all interfaces
- Documented factory patterns and usage scenarios
- Improved method summaries with examples

---

## [1.0.6] - Previous

### Initial Release
- IRefitHttpClientFactory<T> interface for generic client creation
- IRefitHttpClientESauceFactory<T> interface for specialized client creation
- Refit HTTP client factory patterns
- Support for custom HTTP client configurations
