# Unit Converter API - PHP Package

Unit Converter converts values between different units of measurement. Pass a numeric value with source and target unit identifiers to get the converted result and unit abbreviations.

## Installation

Install via Composer:

```bash
composer require apiverve/unitconverter
```

## Getting Started

Get your API key at [APIVerve](https://apiverve.com)

### Basic Usage

```php
<?php

require_once 'vendor/autoload.php';

use APIVerve\Unitconverter\Client;

// Initialize the client
$client = new Client('YOUR_API_KEY');

// Make a request
$response = $client->execute([
    'value' => 100,
    'from' => 'lb',
    'to' => 'kg'
]);

// Print the response
print_r($response);
```


### Error Handling

```php
use APIVerve\Unitconverter\Client;
use APIVerve\Unitconverter\Exceptions\APIException;
use APIVerve\Unitconverter\Exceptions\ValidationException;

try {
    $response = $client->execute(['value' => 100, 'from' => 'lb', 'to' => 'kg']);
    print_r($response['data']);
} catch (ValidationException $e) {
    echo "Validation error: " . implode(', ', $e->getErrors());
} catch (APIException $e) {
    echo "API error: " . $e->getMessage();
    echo "Status code: " . $e->getStatusCode();
}
```

### Debug Mode

```php
// Enable debug logging
$client = new Client(
    apiKey: 'YOUR_API_KEY',
    debug: true
);
```

## Example Response

```json
{
  "status": "ok",
  "error": null,
  "data": {
    "result": {
      "result": 45.36,
      "from": "100 lb",
      "to": "kg"
    },
    "unitDefinitions": {
      "from": {
        "abbr": "lb",
        "measure": "mass",
        "system": "imperial",
        "singular": "Pound",
        "plural": "Pounds"
      },
      "to": {
        "abbr": "kg",
        "measure": "mass",
        "system": "metric",
        "singular": "Kilogram",
        "plural": "Kilograms"
      }
    }
  }
}
```

## Requirements

- PHP 7.4 or higher
- Guzzle HTTP client

## Documentation

For more information, visit the [API Documentation](https://docs.apiverve.com/ref/unitconverter?utm_source=packagist&utm_medium=referral&utm_content=readme).

## Support

- Website: [https://apiverve.com/marketplace/unitconverter?utm_source=php&utm_medium=referral&utm_content=readme](https://apiverve.com/marketplace/unitconverter?utm_source=php&utm_medium=referral&utm_content=readme)
- Email: hello@apiverve.com

## License

This package is available under the [MIT License](LICENSE).
