using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_shield_application_layer_automatic_response resource.
/// </summary>
public class AwsShieldApplicationLayerAutomaticResponse : TerraformResource
{
    public AwsShieldApplicationLayerAutomaticResponse(string name) : base("aws_shield_application_layer_automatic_response", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    public string? Action
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action")?.Value;
        set => this.WithProperty("action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public string? ResourceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_arn")?.Value;
        set => this.WithProperty("resource_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
