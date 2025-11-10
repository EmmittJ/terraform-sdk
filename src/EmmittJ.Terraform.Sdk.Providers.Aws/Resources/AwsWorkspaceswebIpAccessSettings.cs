using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ip_rule in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebIpAccessSettingsIpRuleBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The ip_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpRange is required")]
    public required TerraformProperty<string> IpRange
    {
        get => GetProperty<TerraformProperty<string>>("ip_range");
        set => WithProperty("ip_range", value);
    }

}

/// <summary>
/// Manages a aws_workspacesweb_ip_access_settings resource.
/// </summary>
public class AwsWorkspaceswebIpAccessSettings : TerraformResource
{
    public AwsWorkspaceswebIpAccessSettings(string name) : base("aws_workspacesweb_ip_access_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("associated_portal_arns");
        this.DeclareOutput("ip_access_settings_arn");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AdditionalEncryptionContext
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("additional_encryption_context");
        set => this.WithProperty("additional_encryption_context", value);
    }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    public TerraformProperty<string>? CustomerManagedKey
    {
        get => GetProperty<TerraformProperty<string>>("customer_managed_key");
        set => this.WithProperty("customer_managed_key", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
    /// Block for ip_rule.
    /// Nesting mode: list
    /// </summary>
    public List<AwsWorkspaceswebIpAccessSettingsIpRuleBlock>? IpRule
    {
        get => GetProperty<List<AwsWorkspaceswebIpAccessSettingsIpRuleBlock>>("ip_rule");
        set => this.WithProperty("ip_rule", value);
    }

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    public TerraformExpression AssociatedPortalArns => this["associated_portal_arns"];

    /// <summary>
    /// The ip_access_settings_arn attribute.
    /// </summary>
    public TerraformExpression IpAccessSettingsArn => this["ip_access_settings_arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
