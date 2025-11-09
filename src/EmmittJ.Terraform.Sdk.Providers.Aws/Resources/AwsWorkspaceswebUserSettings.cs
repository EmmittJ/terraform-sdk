using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_workspacesweb_user_settings resource.
/// </summary>
public class AwsWorkspaceswebUserSettings : TerraformResource
{
    public AwsWorkspaceswebUserSettings(string name) : base("aws_workspacesweb_user_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("associated_portal_arns");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("user_settings_arn");
    }

    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    public TerraformMapProperty<string>? AdditionalEncryptionContext
    {
        get => GetProperty<TerraformMapProperty<string>>("additional_encryption_context");
        set => this.WithProperty("additional_encryption_context", value);
    }

    /// <summary>
    /// The copy_allowed attribute.
    /// </summary>
    public TerraformProperty<string>? CopyAllowed
    {
        get => GetProperty<TerraformProperty<string>>("copy_allowed");
        set => this.WithProperty("copy_allowed", value);
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
    /// The deep_link_allowed attribute.
    /// </summary>
    public TerraformProperty<string>? DeepLinkAllowed
    {
        get => GetProperty<TerraformProperty<string>>("deep_link_allowed");
        set => this.WithProperty("deep_link_allowed", value);
    }

    /// <summary>
    /// The disconnect_timeout_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? DisconnectTimeoutInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("disconnect_timeout_in_minutes");
        set => this.WithProperty("disconnect_timeout_in_minutes", value);
    }

    /// <summary>
    /// The download_allowed attribute.
    /// </summary>
    public TerraformProperty<string>? DownloadAllowed
    {
        get => GetProperty<TerraformProperty<string>>("download_allowed");
        set => this.WithProperty("download_allowed", value);
    }

    /// <summary>
    /// The idle_disconnect_timeout_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? IdleDisconnectTimeoutInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("idle_disconnect_timeout_in_minutes");
        set => this.WithProperty("idle_disconnect_timeout_in_minutes", value);
    }

    /// <summary>
    /// The paste_allowed attribute.
    /// </summary>
    public TerraformProperty<string>? PasteAllowed
    {
        get => GetProperty<TerraformProperty<string>>("paste_allowed");
        set => this.WithProperty("paste_allowed", value);
    }

    /// <summary>
    /// The print_allowed attribute.
    /// </summary>
    public TerraformProperty<string>? PrintAllowed
    {
        get => GetProperty<TerraformProperty<string>>("print_allowed");
        set => this.WithProperty("print_allowed", value);
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The upload_allowed attribute.
    /// </summary>
    public TerraformProperty<string>? UploadAllowed
    {
        get => GetProperty<TerraformProperty<string>>("upload_allowed");
        set => this.WithProperty("upload_allowed", value);
    }

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    public TerraformExpression AssociatedPortalArns => this["associated_portal_arns"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The user_settings_arn attribute.
    /// </summary>
    public TerraformExpression UserSettingsArn => this["user_settings_arn"];

}
