# Simple Example of a RateLimiter for a WebAPI

* This Example uses a FixedWindow-RateLimiter.
* The example limit is set to 2 requests per 10 seconds.

#### When the rate limit is exceeded, the following response is returned:

    type:  "https://tools.ietf.org/html/rfc6585#section-4"<br>
    title:  "Rate Limit Exceeded"<br>
    status:  429<br>
    detail:  "Rate limit of 2 requests per 10 seconds exceeded."<br>
