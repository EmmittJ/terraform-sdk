using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_security_token_service_preferences resource.
/// </summary>
public class AwsIamSecurityTokenServicePreferences : TerraformResource
{
    public AwsIamSecurityTokenServicePreferences(string name) : base("aws_iam_security_token_service_preferences", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The global_endpoint_token_version attribute.
    /// </summary>
    public string? GlobalEndpointTokenVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("global_endpoint_token_version")?.Value;
        set => this.WithProperty("global_endpoint_token_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
