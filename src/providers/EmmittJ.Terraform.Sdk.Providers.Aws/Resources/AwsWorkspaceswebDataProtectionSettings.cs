using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for inline_redaction_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The global_confidence_level attribute.
    /// </summary>
    public TerraformProperty<double>? GlobalConfidenceLevel
    {
        set => SetProperty("global_confidence_level", value);
    }

    /// <summary>
    /// The global_enforced_urls attribute.
    /// </summary>
    public List<TerraformProperty<string>>? GlobalEnforcedUrls
    {
        set => SetProperty("global_enforced_urls", value);
    }

    /// <summary>
    /// The global_exempt_urls attribute.
    /// </summary>
    public List<TerraformProperty<string>>? GlobalExemptUrls
    {
        set => SetProperty("global_exempt_urls", value);
    }

}

/// <summary>
/// Manages a aws_workspacesweb_data_protection_settings resource.
/// </summary>
public class AwsWorkspaceswebDataProtectionSettings : TerraformResource
{
    public AwsWorkspaceswebDataProtectionSettings(string name) : base("aws_workspacesweb_data_protection_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("associated_portal_arns");
        SetOutput("data_protection_settings_arn");
        SetOutput("tags_all");
        SetOutput("additional_encryption_context");
        SetOutput("customer_managed_key");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> AdditionalEncryptionContext
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("additional_encryption_context");
        set => SetProperty("additional_encryption_context", value);
    }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    public TerraformProperty<string> CustomerManagedKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_managed_key");
        set => SetProperty("customer_managed_key", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
    /// Block for inline_redaction_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlock>? InlineRedactionConfiguration
    {
        set => SetProperty("inline_redaction_configuration", value);
    }

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    public TerraformExpression AssociatedPortalArns => this["associated_portal_arns"];

    /// <summary>
    /// The data_protection_settings_arn attribute.
    /// </summary>
    public TerraformExpression DataProtectionSettingsArn => this["data_protection_settings_arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
