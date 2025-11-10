using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsApiGatewayRestApiPutTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_api_gateway_rest_api_put resource.
/// </summary>
public class AwsApiGatewayRestApiPut : TerraformResource
{
    public AwsApiGatewayRestApiPut(string name) : base("aws_api_gateway_rest_api_put", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Body is required")]
    public required TerraformProperty<string> Body
    {
        get => GetProperty<TerraformProperty<string>>("body");
        set => this.WithProperty("body", value);
    }

    /// <summary>
    /// The fail_on_warnings attribute.
    /// </summary>
    public TerraformProperty<bool>? FailOnWarnings
    {
        get => GetProperty<TerraformProperty<bool>>("fail_on_warnings");
        set => this.WithProperty("fail_on_warnings", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformProperty<string> RestApiId
    {
        get => GetProperty<TerraformProperty<string>>("rest_api_id");
        set => this.WithProperty("rest_api_id", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Triggers
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("triggers");
        set => this.WithProperty("triggers", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsApiGatewayRestApiPutTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsApiGatewayRestApiPutTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
