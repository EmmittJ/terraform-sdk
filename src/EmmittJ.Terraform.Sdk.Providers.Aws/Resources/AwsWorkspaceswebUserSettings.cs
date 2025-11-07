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
    public TerraformLiteralProperty<Dictionary<string, string>>? AdditionalEncryptionContext
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("additional_encryption_context");
        set => this.WithProperty("additional_encryption_context", value);
    }

    /// <summary>
    /// The copy_allowed attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CopyAllowed
    {
        get => GetProperty<TerraformLiteralProperty<string>>("copy_allowed");
        set => this.WithProperty("copy_allowed", value);
    }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomerManagedKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_managed_key");
        set => this.WithProperty("customer_managed_key", value);
    }

    /// <summary>
    /// The deep_link_allowed attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeepLinkAllowed
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deep_link_allowed");
        set => this.WithProperty("deep_link_allowed", value);
    }

    /// <summary>
    /// The disconnect_timeout_in_minutes attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DisconnectTimeoutInMinutes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disconnect_timeout_in_minutes");
        set => this.WithProperty("disconnect_timeout_in_minutes", value);
    }

    /// <summary>
    /// The download_allowed attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DownloadAllowed
    {
        get => GetProperty<TerraformLiteralProperty<string>>("download_allowed");
        set => this.WithProperty("download_allowed", value);
    }

    /// <summary>
    /// The idle_disconnect_timeout_in_minutes attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? IdleDisconnectTimeoutInMinutes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("idle_disconnect_timeout_in_minutes");
        set => this.WithProperty("idle_disconnect_timeout_in_minutes", value);
    }

    /// <summary>
    /// The paste_allowed attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PasteAllowed
    {
        get => GetProperty<TerraformLiteralProperty<string>>("paste_allowed");
        set => this.WithProperty("paste_allowed", value);
    }

    /// <summary>
    /// The print_allowed attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrintAllowed
    {
        get => GetProperty<TerraformLiteralProperty<string>>("print_allowed");
        set => this.WithProperty("print_allowed", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
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
    /// The upload_allowed attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UploadAllowed
    {
        get => GetProperty<TerraformLiteralProperty<string>>("upload_allowed");
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
