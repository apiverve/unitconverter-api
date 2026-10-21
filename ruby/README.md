# Unit Converter API - Ruby Gem

Unit Converter converts values between different units of measurement. Pass a numeric value with source and target unit identifiers to get the converted result and unit abbreviations.

## Installation

Add this line to your application's Gemfile:

```ruby
gem 'apiverve_unitconverter'
```

And then execute:

```bash
$ bundle install
```

Or install it yourself as:

```bash
$ gem install apiverve_unitconverter
```

## Getting Started

Get your API key at [APIVerve](https://apiverve.com)

### Basic Usage

```ruby
require 'apiverve_unitconverter'

# Initialize the client
client = APIVerve::Unitconverter::Client.new(api_key: "YOUR_API_KEY")

# Make a request
response = client.execute({
  value: 100,
  from: "lb",
  to: "kg"
})

# Print the response
puts response
```


### Error Handling

```ruby
begin
  response = client.execute({ value: 100, from: "lb", to: "kg" })
  puts response["data"]
rescue APIVerve::Unitconverter::ValidationError => e
  puts "Validation error: #{e.errors.join(', ')}"
rescue APIVerve::Unitconverter::APIError => e
  puts "API error: #{e.message}"
  puts "Status code: #{e.status_code}"
end
```

### Debug Mode

```ruby
# Enable debug logging
client = APIVerve::Unitconverter::Client.new(
  api_key: "YOUR_API_KEY",
  debug: true
)
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

## Documentation

For more information, visit the [API Documentation](https://docs.apiverve.com/ref/unitconverter?utm_source=rubygems&utm_medium=referral&utm_content=readme).

## Support

- Website: [https://apiverve.com/marketplace/unitconverter?utm_source=ruby&utm_medium=referral&utm_content=readme](https://apiverve.com/marketplace/unitconverter?utm_source=ruby&utm_medium=referral&utm_content=readme)
- Email: hello@apiverve.com

## License

This gem is available under the [MIT License](LICENSE).
