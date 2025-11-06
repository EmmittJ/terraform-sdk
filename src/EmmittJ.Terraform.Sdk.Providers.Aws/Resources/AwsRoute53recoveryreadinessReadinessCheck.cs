using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53recoveryreadiness_readiness_check resource.
/// </summary>
public class AwsRoute53recoveryreadinessReadinessCheck : TerraformResource
{
    public AwsRoute53recoveryreadinessReadinessCheck(string name) : base("aws_route53recoveryreadiness_readiness_check", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The readiness_check_name attribute.
    /// </summary>
    public string? ReadinessCheckName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("readiness_check_name")?.Value;
        set => this.WithProperty("readiness_check_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_set_name attribute.
    /// </summary>
    public string? ResourceSetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_set_name")?.Value;
        set => this.WithProperty("resource_set_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
