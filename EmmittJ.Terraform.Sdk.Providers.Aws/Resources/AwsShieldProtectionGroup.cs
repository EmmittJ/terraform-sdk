using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_shield_protection_group resource.
/// </summary>
public class AwsShieldProtectionGroup : TerraformResource
{
    public AwsShieldProtectionGroup(string name) : base("aws_shield_protection_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("protection_group_arn");
    }

    /// <summary>
    /// The aggregation attribute.
    /// </summary>
    public string? Aggregation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aggregation")?.Value;
        set => this.WithProperty("aggregation", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The members attribute.
    /// </summary>
    public List<string>? Members
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("members")?.Value;
        set => this.WithProperty("members", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    public string? Pattern
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pattern")?.Value;
        set => this.WithProperty("pattern", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The protection_group_id attribute.
    /// </summary>
    public string? ProtectionGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protection_group_id")?.Value;
        set => this.WithProperty("protection_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public string? ResourceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_type")?.Value;
        set => this.WithProperty("resource_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The protection_group_arn attribute.
    /// </summary>
    public TerraformExpression ProtectionGroupArn => this["protection_group_arn"];

}
