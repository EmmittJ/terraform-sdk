using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for notification_settings in .
/// Nesting mode: set
/// </summary>
public class AwsRolesanywhereTrustAnchorNotificationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The channel attribute.
    /// </summary>
    public TerraformProperty<string>? Channel
    {
        get => GetProperty<TerraformProperty<string>>("channel");
        set => WithProperty("channel", value);
    }

    /// <summary>
    /// The configured_by attribute.
    /// </summary>
    public TerraformProperty<string>? ConfiguredBy
    {
        get => GetProperty<TerraformProperty<string>>("configured_by");
        set => WithProperty("configured_by", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The event attribute.
    /// </summary>
    public TerraformProperty<string>? Event
    {
        get => GetProperty<TerraformProperty<string>>("event");
        set => WithProperty("event", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    public TerraformProperty<double>? Threshold
    {
        get => GetProperty<TerraformProperty<double>>("threshold");
        set => WithProperty("threshold", value);
    }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AwsRolesanywhereTrustAnchorSourceBlock : TerraformBlock
{
    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceType is required")]
    public required TerraformProperty<string> SourceType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source_type");
        set => WithProperty("source_type", value);
    }

}

/// <summary>
/// Manages a aws_rolesanywhere_trust_anchor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsRolesanywhereTrustAnchor : TerraformResource
{
    public AwsRolesanywhereTrustAnchor(string name) : base("aws_rolesanywhere_trust_anchor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for notification_settings.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 NotificationSettings block(s) allowed")]
    public HashSet<AwsRolesanywhereTrustAnchorNotificationSettingsBlock>? NotificationSettings
    {
        get => GetProperty<HashSet<AwsRolesanywhereTrustAnchorNotificationSettingsBlock>>("notification_settings");
        set => this.WithProperty("notification_settings", value);
    }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public List<AwsRolesanywhereTrustAnchorSourceBlock>? Source
    {
        get => GetProperty<List<AwsRolesanywhereTrustAnchorSourceBlock>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
