using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dashboard_publish_options in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDashboardDashboardPublishOptionsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for definition in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDashboardDefinitionBlock : TerraformBlock
{
}

/// <summary>
/// Block type for parameters in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDashboardParametersBlock : TerraformBlock
{
}

/// <summary>
/// Block type for permissions in .
/// Nesting mode: set
/// </summary>
public class AwsQuicksightDashboardPermissionsBlock : TerraformBlock
{
    /// <summary>
    /// The actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    public HashSet<TerraformProperty<string>>? Actions
    {
        set => SetProperty("actions", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformProperty<string> Principal
    {
        set => SetProperty("principal", value);
    }

}

/// <summary>
/// Block type for source_entity in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDashboardSourceEntityBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsQuicksightDashboardTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_quicksight_dashboard resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsQuicksightDashboard : TerraformResource
{
    public AwsQuicksightDashboard(string name) : base("aws_quicksight_dashboard", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("created_time");
        SetOutput("last_published_time");
        SetOutput("last_updated_time");
        SetOutput("source_entity_arn");
        SetOutput("status");
        SetOutput("version_number");
        SetOutput("aws_account_id");
        SetOutput("dashboard_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("theme_arn");
        SetOutput("version_description");
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string> AwsAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aws_account_id");
        set => SetProperty("aws_account_id", value);
    }

    /// <summary>
    /// The dashboard_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DashboardId is required")]
    public required TerraformProperty<string> DashboardId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dashboard_id");
        set => SetProperty("dashboard_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The theme_arn attribute.
    /// </summary>
    public TerraformProperty<string> ThemeArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("theme_arn");
        set => SetProperty("theme_arn", value);
    }

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionDescription is required")]
    public required TerraformProperty<string> VersionDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version_description");
        set => SetProperty("version_description", value);
    }

    /// <summary>
    /// Block for dashboard_publish_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DashboardPublishOptions block(s) allowed")]
    public List<AwsQuicksightDashboardDashboardPublishOptionsBlock>? DashboardPublishOptions
    {
        set => SetProperty("dashboard_publish_options", value);
    }

    /// <summary>
    /// Block for definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Definition block(s) allowed")]
    public List<AwsQuicksightDashboardDefinitionBlock>? Definition
    {
        set => SetProperty("definition", value);
    }

    /// <summary>
    /// Block for parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Parameters block(s) allowed")]
    public List<AwsQuicksightDashboardParametersBlock>? Parameters
    {
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// Block for permissions.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(64, ErrorMessage = "Maximum 64 Permissions block(s) allowed")]
    public HashSet<AwsQuicksightDashboardPermissionsBlock>? Permissions
    {
        set => SetProperty("permissions", value);
    }

    /// <summary>
    /// Block for source_entity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceEntity block(s) allowed")]
    public List<AwsQuicksightDashboardSourceEntityBlock>? SourceEntity
    {
        set => SetProperty("source_entity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsQuicksightDashboardTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

    /// <summary>
    /// The last_published_time attribute.
    /// </summary>
    public TerraformExpression LastPublishedTime => this["last_published_time"];

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformExpression LastUpdatedTime => this["last_updated_time"];

    /// <summary>
    /// The source_entity_arn attribute.
    /// </summary>
    public TerraformExpression SourceEntityArn => this["source_entity_arn"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The version_number attribute.
    /// </summary>
    public TerraformExpression VersionNumber => this["version_number"];

}
