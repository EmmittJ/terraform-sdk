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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Aggregation is required")]
    public required TerraformProperty<string> Aggregation
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
    public List<TerraformProperty<string>>? Members
    {
        get => GetProperty<List<TerraformProperty<string>>>("members");
        set => this.WithProperty("members", value);
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformProperty<string> Pattern
    {
        get => GetProperty<TerraformProperty<string>>("pattern");
        set => this.WithProperty("pattern", value);
    }

    /// <summary>
    /// The protection_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtectionGroupId is required")]
    public required TerraformProperty<string> ProtectionGroupId
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The protection_group_arn attribute.
    /// </summary>
    public TerraformExpression ProtectionGroupArn => this["protection_group_arn"];

}
