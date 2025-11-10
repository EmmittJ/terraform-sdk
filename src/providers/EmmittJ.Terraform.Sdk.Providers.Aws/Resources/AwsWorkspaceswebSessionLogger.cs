using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_filter in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebSessionLoggerEventFilterBlock : TerraformBlock
{
    /// <summary>
    /// The include attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Include
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("include");
        set => WithProperty("include", value);
    }

}

/// <summary>
/// Block type for log_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebSessionLoggerLogConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_workspacesweb_session_logger resource.
/// </summary>
public class AwsWorkspaceswebSessionLogger : TerraformResource
{
    public AwsWorkspaceswebSessionLogger(string name) : base("aws_workspacesweb_session_logger", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("associated_portal_arns");
        this.WithOutput("session_logger_arn");
        this.WithOutput("tags_all");
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
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
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
    /// Block for event_filter.
    /// Nesting mode: list
    /// </summary>
    public List<AwsWorkspaceswebSessionLoggerEventFilterBlock>? EventFilter
    {
        get => GetProperty<List<AwsWorkspaceswebSessionLoggerEventFilterBlock>>("event_filter");
        set => this.WithProperty("event_filter", value);
    }

    /// <summary>
    /// Block for log_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsWorkspaceswebSessionLoggerLogConfigurationBlock>? LogConfiguration
    {
        get => GetProperty<List<AwsWorkspaceswebSessionLoggerLogConfigurationBlock>>("log_configuration");
        set => this.WithProperty("log_configuration", value);
    }

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    public TerraformExpression AssociatedPortalArns => this["associated_portal_arns"];

    /// <summary>
    /// The session_logger_arn attribute.
    /// </summary>
    public TerraformExpression SessionLoggerArn => this["session_logger_arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
