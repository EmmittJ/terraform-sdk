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
    public TerraformLiteralProperty<string>? Aggregation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aggregation");
        set => this.WithProperty("aggregation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The members attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Members
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("members");
        set => this.WithProperty("members", value);
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Pattern
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pattern");
        set => this.WithProperty("pattern", value);
    }

    /// <summary>
    /// The protection_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProtectionGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protection_group_id");
        set => this.WithProperty("protection_group_id", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_type");
        set => this.WithProperty("resource_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The protection_group_arn attribute.
    /// </summary>
    public TerraformExpression ProtectionGroupArn => this["protection_group_arn"];

}
