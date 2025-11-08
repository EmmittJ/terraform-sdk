using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();
builder.AddRedisClient("cache");

var app = builder.Build();

app.MapDefaultEndpoints();

app.MapGet("/", () =>
{
    return Results.Content("""
    <html>
        <body>
            <h1>Terraform Playground API</h1>
            <ul>
                <li><a href="/redis/ping">Redis Ping</a></li>
                <li><a href="/redis/set">Redis Set</a></li>
                <li><a href="/redis/get">Redis Get</a></li>
                <li><a href="/healthz">Health Check</a></li>
            </ul>
        </body>
    </html>
    """,
    "text/html");
});

app.MapGet("/redis/ping", async (IConnectionMultiplexer connection) =>
{
    var db = connection.GetDatabase();
    var pingTime = await db.PingAsync();
    return new { status = "ok", pingTime = pingTime.TotalMilliseconds };
});

app.MapGet("/redis/set", async (IConnectionMultiplexer connection) =>
{
    var db = connection.GetDatabase();
    var key = $"test:{Guid.NewGuid()}";
    var value = DateTimeOffset.UtcNow.ToString("O");
    await db.StringSetAsync(key, value);
    return new { key, value, message = "Value set in Redis" };
});

app.MapGet("/redis/get", async (IConnectionMultiplexer connection) =>
{
    var db = connection.GetDatabase();
    var key = "test:*";
    var server = connection.GetServer(connection.GetEndPoints().First());
    var keys = server.Keys(pattern: key).Take(10).ToArray();

    var values = new List<object>();
    foreach (var k in keys)
    {
        var value = await db.StringGetAsync(k);
        values.Add(new { key = k.ToString(), value = value.ToString() });
    }

    return new { count = values.Count, items = values };
});

app.Run();
