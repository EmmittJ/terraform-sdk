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
    public TerraformProperty<string>? Aggregation
    {
        get => GetProperty<TerraformProperty<string>>("aggregation");
        set => this.WithProperty("aggregation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The members attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Members
    {
        get => GetProperty<TerraformProperty<List<string>>>("members");
        set => this.WithProperty("members", value);
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    public TerraformProperty<string>? Pattern
    {
        get => GetProperty<TerraformProperty<string>>("pattern");
        set => this.WithProperty("pattern", value);
    }

    /// <summary>
    /// The protection_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProtectionGroupId
    {
        get => GetProperty<TerraformProperty<string>>("protection_group_id");
        set => this.WithProperty("protection_group_id", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceType
    {
        get => GetProperty<TerraformProperty<string>>("resource_type");
        set => this.WithProperty("resource_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The protection_group_arn attribute.
    /// </summary>
    public TerraformExpression ProtectionGroupArn => this["protection_group_arn"];

}
