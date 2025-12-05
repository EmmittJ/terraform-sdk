namespace EmmittJ.Terraform.Sdk;

using System.Runtime.CompilerServices;
using System.Text;

/// <summary>
/// Interpolated string handler that converts C# string interpolation into Terraform string template expressions.
/// Enables natural syntax: <c>Tf.Str($"{locals["name_prefix"]}-web")</c> produces <c>"${local.name_prefix}-web"</c>
/// </summary>
/// <remarks>
/// <para>
/// This handler intercepts C# string interpolation at compile time and builds a Terraform string template
/// expression instead of a literal string. It converts expressions to their HCL reference syntax.
/// </para>
/// <para>
/// Usage:
/// <code>
/// // Variable reference
/// Tf.Str($"prefix-{variable}-suffix")  // → "prefix-${var.variable}-suffix"
///
/// // Local value reference
/// Tf.Str($"{locals["name"]}-web")      // → "${local.name}-web"
///
/// // Resource attribute reference
/// Tf.Str($"vpc-{vpc["id"]}")           // → "vpc-${aws_vpc.main.id}"
///
/// // Multiple expressions
/// Tf.Str($"{region}/{environment}")    // → "${var.region}/${var.environment}"
/// </code>
/// </para>
/// </remarks>
[InterpolatedStringHandler]
public ref struct TerraformInterpolatedStringHandler
{
    private readonly StringBuilder _builder;
    private readonly List<object> _parts;
    private readonly List<string?> _formats;

    /// <summary>
    /// Initializes the handler with the literal length and formatted count.
    /// </summary>
    /// <param name="literalLength">The number of constant characters in the interpolated string.</param>
    /// <param name="formattedCount">The number of interpolated expressions.</param>
    public TerraformInterpolatedStringHandler(int literalLength, int formattedCount)
    {
        _builder = new StringBuilder(literalLength);
        _parts = new List<object>(formattedCount + 1);
        _formats = new List<string?>(formattedCount + 1);
    }

    /// <summary>
    /// Appends a literal string part.
    /// Escapes single braces to double braces for Terraform compatibility.
    /// </summary>
    public void AppendLiteral(string value)
    {
        // Flush any pending builder content
        if (_builder.Length > 0)
        {
            _parts.Add(_builder.ToString());
            _formats.Add(null);
            _builder.Clear();
        }

        // Escape single braces that aren't already escaped
        // This prevents conflicts with Terraform's ${} syntax
        value = EscapeBraces(value);
        _parts.Add(value);
        _formats.Add(null);
    }

    /// <summary>
    /// Escapes single braces to double braces while preserving already-escaped braces.
    /// </summary>
    private static string EscapeBraces(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return value;
        }

        var sb = new StringBuilder(value.Length);
        for (var i = 0; i < value.Length; i++)
        {
            var ch = value[i];
            if (ch == '{' || ch == '}')
            {
                // Check if already escaped (double brace)
                var isEscaped = i + 1 < value.Length && value[i + 1] == ch;
                if (!isEscaped)
                {
                    // Escape single brace by doubling it
                    sb.Append(ch);
                }
                sb.Append(ch);
            }
            else
            {
                sb.Append(ch);
            }
        }
        return sb.ToString();
    }

    /// <summary>
    /// Appends a formatted TerraformExpression value.
    /// </summary>
    public void AppendFormatted(TerraformExpression value)
    {
        // Flush any pending builder content
        if (_builder.Length > 0)
        {
            _parts.Add(_builder.ToString());
            _formats.Add(null);
            _builder.Clear();
        }

        _parts.Add(value);
        _formats.Add(null);
    }

    /// <summary>
    /// Appends a formatted TerraformBlock value, using its reference identifier.
    /// Enables syntax like <c>Tf.Interpolate($"{variable}")</c> to produce <c>"${var.variable}"</c>.
    /// </summary>
    public void AppendFormatted(TerraformBlock value)
    {
        // Flush any pending builder content
        if (_builder.Length > 0)
        {
            _parts.Add(_builder.ToString());
            _formats.Add(null);
            _builder.Clear();
        }

        // Use the block's reference identifier to create a reference expression
        _parts.Add(value.ToReference());
        _formats.Add(null);
    }

    /// <summary>
    /// Appends a formatted string value.
    /// </summary>
    public void AppendFormatted(string value)
    {
        AppendFormatted(value, format: null);
    }

    /// <summary>
    /// Appends a formatted string value with an optional format specifier.
    /// </summary>
    /// <param name="value">The string value to append.</param>
    /// <param name="format">Optional format specifier (e.g., "base64encode", "uri").</param>
    public void AppendFormatted(string value, string? format)
    {
        // Flush any pending builder content
        if (_builder.Length > 0)
        {
            _parts.Add(_builder.ToString());
            _formats.Add(null);
            _builder.Clear();
        }

        // Store string as literal expression (strings are treated as expressions in interpolations)
        _parts.Add(TerraformExpression.Literal(value));
        _formats.Add(format);
    }

    /// <summary>
    /// Appends a formatted object value.
    /// </summary>
    public void AppendFormatted<T>(T value)
    {
        AppendFormatted(value, format: null);
    }

    /// <summary>
    /// Appends a formatted object value with an optional format specifier.
    /// </summary>
    /// <param name="value">The value to append.</param>
    /// <param name="format">Optional format specifier (e.g., "jsonencode", "base64encode", "sensitive", "uri").</param>
    /// <remarks>
    /// Supported format specifiers:
    /// <list type="bullet">
    /// <item><term>jsonencode</term><description>Wraps the value in jsonencode() function</description></item>
    /// <item><term>base64encode</term><description>Wraps the value in base64encode() function</description></item>
    /// <item><term>base64decode</term><description>Wraps the value in base64decode() function</description></item>
    /// <item><term>sensitive</term><description>Wraps the value in sensitive() function</description></item>
    /// <item><term>uri</term><description>Wraps the value in urlencode() function</description></item>
    /// </list>
    /// </remarks>
    public void AppendFormatted<T>(T value, string? format)
    {
        // Flush any pending builder content
        if (_builder.Length > 0)
        {
            _parts.Add(_builder.ToString());
            _formats.Add(null);
            _builder.Clear();
        }

        if (value is null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        // For TerraformBlock, store its reference expression instead of the block itself
        // This ensures blocks resolve to references (e.g., var.region) rather than content
        object partToStore = value is TerraformBlock block ? block.ToReference() : value;

        // Store the value and format separately; TerraformInterpolationExpression will apply format during HCL generation
        _parts.Add(partToStore);
        _formats.Add(format);
    }

    /// <summary>
    /// Gets the expression built from the interpolated string.
    /// </summary>
    public TerraformExpression GetExpression()
    {
        // Flush any pending builder content
        if (_builder.Length > 0)
        {
            _parts.Add(_builder.ToString());
            _formats.Add(null);
            _builder.Clear();
        }

        // If there's only one part and it's a string literal, return it directly
        if (_parts.Count == 1 && _parts[0] is string literalString)
        {
            return TerraformExpression.Literal(literalString);
        }

        // Otherwise, create a string interpolation expression that will handle resolution
        return new TerraformInterpolationExpression(_parts.ToArray(), _formats.ToArray());
    }
}
