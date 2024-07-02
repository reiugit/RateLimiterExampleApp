# Simple Example of a RateLimiter for a WebAPI

* This Example uses a FixedWindow-RateLimiter.
* The limit is set to 2 requests per 10 seconds.

When the rate limit is exceeded, the following response is returned:

>  type:  "https://tools.ietf.org/html/rfc6585#section-4"<br>
>  title:  "Rate Limit Exceeded"<br>
>  status:  429<br>
>  detail:  "Rate Limit of 2 requests per 10 seconds exceeded."<br>

  {"type":"https://tools.ietf.org/html/rfc6585#section-4","title":"Rate Limit Exceeded","status":429,"detail":"Rate Limit of 2 requests per 10 seconds exceeded."}
