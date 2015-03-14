# Playing with distributed logging
## Execution delay time
UdpAppender -> logstash (localhost), ~10ms
Redis4net -> redis -> logstash (localhost), ~1ms

## Config
### Redis
####redis-windows: 
https://github.com/ServiceStack/redis-windows
#### Redis4net
https://github.com/govin/redis4net/blob/master/README.md

### UdpAppender
(built-in to log4net)