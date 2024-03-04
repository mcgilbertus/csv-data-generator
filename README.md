# Mock Data Generator utility

**Function**: given a schema, generate a csv file with N records with mock data following the schema

**Schema**: CSV text file with description of fields

Each row has
	fieldName, data type, format, from, to

* fieldName: string

* data type: 

  * string
  * int / long
  * float
  * date: requires format. By default, use YYYY-MM-DD
  * datetime: requires format, by default YYYY-MM-DD HH:mm:SS
  * time: requires format, by default H:m:S
  * timestamp: long number of milliseconds since Epoch (usually 1970-01-01)

* format: string. For date/time fields:

  * YYYY: year with 4 digits
  * YY: year with 2 digits (window 1950, i.e. 87 -> 1987 but 21 -> 2021)
  * M: month unpadded
  * MM: month with two digits, padded with 0
  * D: day of month, unpadded
  * DD: day of month, padded with 0
  * H: hour with one or two digits, unpadded
  * HH: hour with two digits, padded with 0
  * m: minutes of the hour, unpadded
  * mm: minutes of the hour, padded with 0
  * S: seconds, unpadded
  * SS: seconds, padded with 0

* from / to: if needed, specify a range of valid values to generate


**Inputs**: schema file path, number of records to generate, output file path

**Outputs**: file created


