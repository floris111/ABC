# ABCApi

Sample api, example api for consuming carton status. 
Currently there is 1 endpoint available. `api/Carton`. 

You can post carton status to this endpoint. Please see the example payloads for example how to call (and not).

`swagger.json` contains the swagger defenition for this api.

## Known limitations
- No unit testing, not needed for example
- No error logging
- Only 1 endpoint available for posting carton status

## Example payloads:

### Valid data, count ok 1 product
```json
{
  "isOk": true,
  "barcode": "008012349999999997",
  "articles": [
    {
      "articleNumber": "123456",
      "quantity": 5,
      "isOk": true
    }
  ]
}
```
### Valid data, count ok, multiple products
```json
{
  "isOk": true,
  "barcode": "008012349999999987",
  "articles": [
    {
      "articleNumber": "123456",
      "quantity": 2,
      "isOk": true
    },
    {
      "articleNumber": "123457",
      "quantity": 3,
      "isOk": true
    },
    {
      "articleNumber": "123458",
      "quantity": 5,
      "isOk": true
    }
  ]
}
```
### Valid data, count not ok, multiple products
```json
{
  "isOk": false,
  "barcode": "008012349999999977",
  "articles": [
    {
      "articleNumber": "123456",
      "quantity": 2,
      "isOk": false
    },
    {
      "articleNumber": "123457",
      "quantity": 3,
      "isOk": true
    },
    {
      "articleNumber": "123458",
      "quantity": 5,
      "isOk": true
    }
  ]
}
```
### Invalid data, wrong barcode
```json
{
  "isOk": true,
  "barcode": "0080123",
  "articles": [
    {
      "articleNumber": "123456",
      "quantity": 2,
      "isOk": true
    },
    {
      "articleNumber": "123457",
      "quantity": 3,
      "isOk": true
    },
    {
      "articleNumber": "123458",
      "quantity": 5,
      "isOk": true
    }
  ]
}
```
### Invalid data, no articles
```json
{
  "isOk": true,
  "barcode": "008012349999999947",
  "articles": []
}
```
### Invalid data, no quantity
```json
{
  "isOk": true,
  "barcode": "008012349999999997",
  "articles": [
    {
      "articleNumber": "123456",
      "isOk": true
    }
  ]
}
```
