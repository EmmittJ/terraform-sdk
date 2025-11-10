using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for member_definition in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkteamMemberDefinitionBlock : TerraformBlock
{
}

/// <summary>
/// Block type for notification_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkteamNotificationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? NotificationTopicArn
    {
        get => GetProperty<TerraformProperty<string>>("notification_topic_arn");
        set => WithProperty("notification_topic_arn", value);
    }

}

/// <summary>
/// Block type for worker_access_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkteamWorkerAccessConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_sagemaker_workteam resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerWorkteam : TerraformResource
{
    public AwsSagemakerWorkteam(string name) : base("aws_sagemaker_workteam", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("subdomain");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The workforce_name attribute.
    /// </summary>
    public TerraformProperty<string>? WorkforceName
    {
        get => GetProperty<TerraformProperty<string>>("workforce_name");
        set => this.WithProperty("workforce_name", value);
    }

    /// <summary>
    /// The workteam_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkteamName is required")]
    public required TerraformProperty<string> WorkteamName
    {
        get => GetProperty<TerraformProperty<string>>("workteam_name");
        set => this.WithProperty("workteam_name", value);
    }

    /// <summary>
    /// Block for member_definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MemberDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 MemberDefinition block(s) allowed")]
    public List<AwsSagemakerWorkteamMemberDefinitionBlock>? MemberDefinition
    {
        get => GetProperty<List<AwsSagemakerWorkteamMemberDefinitionBlock>>("member_definition");
        set => this.WithProperty("member_definition", value);
    }

    /// <summary>
    /// Block for notification_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfiguration block(s) allowed")]
    public List<AwsSagemakerWorkteamNotificationConfigurationBlock>? NotificationConfiguration
    {
        get => GetProperty<List<AwsSagemakerWorkteamNotificationConfigurationBlock>>("notification_configuration");
        set => this.WithProperty("notification_configuration", value);
    }

    /// <summary>
    /// Block for worker_access_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerAccessConfiguration block(s) allowed")]
    public List<AwsSagemakerWorkteamWorkerAccessConfigurationBlock>? WorkerAccessConfiguration
    {
        get => GetProperty<List<AwsSagemakerWorkteamWorkerAccessConfigurationBlock>>("worker_access_configuration");
        set => this.WithProperty("worker_access_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The subdomain attribute.
    /// </summary>
    public TerraformExpression Subdomain => this["subdomain"];

}
