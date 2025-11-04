using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_resolver_config resource.
/// </summary>
public class AwsRoute53ResolverConfig : TerraformResource
{
    public AwsRoute53ResolverConfig(string name) : base("aws_route53_resolver_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("owner_id");
    }

    /// <summary>
    /// The autodefined_reverse_flag attribute.
    /// </summary>
    public string? AutodefinedReverseFlag
    {
        get => GetProperty<TerraformLiteralProperty<string>>("autodefined_reverse_flag")?.Value;
        set => this.WithProperty("autodefined_reverse_flag", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_id attribute.
    /// </summary>
    public string? ResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_id")?.Value;
        set => this.WithProperty("resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

}
