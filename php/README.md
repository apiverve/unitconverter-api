# Unit Converter API - PHP Package

Unit Converter converts values between 185 units across 23 measures, from length, mass and volume to speed, pressure, data size, energy and electrical units. Pass a numeric value with source and target unit codes to get the converted result and unit abbreviations. On paid plans, precision sets the decimal places and conversions=true adds the value in every unit of the same measure.

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
    'to' => 'kg',
    'precision' => 2,
    'conversions' => true
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
    $response = $client->execute(['value' => 100, 'from' => 'lb', 'to' => 'kg', 'precision' => 2, 'conversions' => true]);
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
    },
    "conversions": {
      "mcg": 45359200000,
      "mg": 45359200,
      "g": 45359.2,
      "kg": 45.36,
      "mt": 0.05,
      "oz": 1600,
      "lb": 100,
      "t": 0.05
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
