using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_shield_subscription resource.
/// </summary>
public class AwsShieldSubscription : TerraformResource
{
    public AwsShieldSubscription(string name) : base("aws_shield_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
    }

    /// <summary>
    /// Whether to automatically renew the subscription when it expires.
    /// </summary>
    public string? AutoRenew
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auto_renew")?.Value;
        set => this.WithProperty("auto_renew", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public bool? SkipDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_destroy")?.Value;
        set => this.WithProperty("skip_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
