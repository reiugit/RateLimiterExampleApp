# Simple Example of a RateLimiter for a WebAPI

* This Example uses a FixedWindow-RateLimiter.
* The limit is set to 2 requests per 10 seconds.

When the rate limit is exceeded, the following response is returned:

>  type:  "https://tools.ietf.org/html/rfc6585#section-4"<br>
>  title:  "Rate Limit Exceeded"<br>
>  status:  429<br>
>  detail:  "Rate Limit of 2 requests per 10 seconds exceeded."<br>

>{
> &nbsp; "type":"https://tools.ietf.org/html/rfc6585#section-4",
> &nbsp; "title":"Rate Limit Exceeded",
> &nbsp; "status":429,
> &nbsp; "detail":"Rate Limit of 2 requests per 10 seconds exceeded."
> }
