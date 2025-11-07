using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public TerraformProperty<string>? Body
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
    public TerraformProperty<Dictionary<string, string>>? Parameters
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("parameters");
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
    public TerraformProperty<string>? RestApiId
    {
        get => GetProperty<TerraformProperty<string>>("rest_api_id");
        set => this.WithProperty("rest_api_id", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Triggers
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("triggers");
        set => this.WithProperty("triggers", value);
    }

}
