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
        set => SetProperty("include", value);
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
        SetOutput("associated_portal_arns");
        SetOutput("session_logger_arn");
        SetOutput("tags_all");
        SetOutput("additional_encryption_context");
        SetOutput("customer_managed_key");
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
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string> DisplayName
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
    /// Block for event_filter.
    /// Nesting mode: list
    /// </summary>
    public List<AwsWorkspaceswebSessionLoggerEventFilterBlock>? EventFilter
    {
        set => SetProperty("event_filter", value);
    }

    /// <summary>
    /// Block for log_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsWorkspaceswebSessionLoggerLogConfigurationBlock>? LogConfiguration
    {
        set => SetProperty("log_configuration", value);
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
