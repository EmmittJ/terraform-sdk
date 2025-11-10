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
        SetOutput("protection_group_arn");
        SetOutput("aggregation");
        SetOutput("id");
        SetOutput("members");
        SetOutput("pattern");
        SetOutput("protection_group_id");
        SetOutput("resource_type");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The aggregation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Aggregation is required")]
    public required TerraformProperty<string> Aggregation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aggregation");
        set => SetProperty("aggregation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The members attribute.
    /// </summary>
    public List<TerraformProperty<string>> Members
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("members");
        set => SetProperty("members", value);
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformProperty<string> Pattern
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pattern");
        set => SetProperty("pattern", value);
    }

    /// <summary>
    /// The protection_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtectionGroupId is required")]
    public required TerraformProperty<string> ProtectionGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protection_group_id");
        set => SetProperty("protection_group_id", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformProperty<string> ResourceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_type");
        set => SetProperty("resource_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The protection_group_arn attribute.
    /// </summary>
    public TerraformExpression ProtectionGroupArn => this["protection_group_arn"];

}
