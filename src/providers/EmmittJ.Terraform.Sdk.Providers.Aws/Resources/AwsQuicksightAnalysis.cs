using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for definition in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightAnalysisDefinitionBlock : TerraformBlock
{
}

/// <summary>
/// Block type for parameters in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightAnalysisParametersBlock : TerraformBlock
{
}

/// <summary>
/// Block type for permissions in .
/// Nesting mode: set
/// </summary>
public class AwsQuicksightAnalysisPermissionsBlock : TerraformBlock
{
    /// <summary>
    /// The actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    public HashSet<TerraformProperty<string>>? Actions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("actions");
        set => WithProperty("actions", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformProperty<string> Principal
    {
        get => GetRequiredProperty<TerraformProperty<string>>("principal");
        set => WithProperty("principal", value);
    }

}

/// <summary>
/// Block type for source_entity in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightAnalysisSourceEntityBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsQuicksightAnalysisTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_quicksight_analysis resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsQuicksightAnalysis : TerraformResource
{
    public AwsQuicksightAnalysis(string name) : base("aws_quicksight_analysis", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("created_time");
        this.WithOutput("last_published_time");
        this.WithOutput("last_updated_time");
        this.WithOutput("status");
    }

    /// <summary>
    /// The analysis_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AnalysisId is required")]
    public required TerraformProperty<string> AnalysisId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("analysis_id");
        set => this.WithProperty("analysis_id", value);
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AwsAccountId
    {
        get => GetProperty<TerraformProperty<string>>("aws_account_id");
        set => this.WithProperty("aws_account_id", value);
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
    /// The recovery_window_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? RecoveryWindowInDays
    {
        get => GetProperty<TerraformProperty<double>>("recovery_window_in_days");
        set => this.WithProperty("recovery_window_in_days", value);
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
    /// The theme_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ThemeArn
    {
        get => GetProperty<TerraformProperty<string>>("theme_arn");
        set => this.WithProperty("theme_arn", value);
    }

    /// <summary>
    /// Block for definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Definition block(s) allowed")]
    public List<AwsQuicksightAnalysisDefinitionBlock>? Definition
    {
        get => GetProperty<List<AwsQuicksightAnalysisDefinitionBlock>>("definition");
        set => this.WithProperty("definition", value);
    }

    /// <summary>
    /// Block for parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Parameters block(s) allowed")]
    public List<AwsQuicksightAnalysisParametersBlock>? Parameters
    {
        get => GetProperty<List<AwsQuicksightAnalysisParametersBlock>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// Block for permissions.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(64, ErrorMessage = "Maximum 64 Permissions block(s) allowed")]
    public HashSet<AwsQuicksightAnalysisPermissionsBlock>? Permissions
    {
        get => GetProperty<HashSet<AwsQuicksightAnalysisPermissionsBlock>>("permissions");
        set => this.WithProperty("permissions", value);
    }

    /// <summary>
    /// Block for source_entity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceEntity block(s) allowed")]
    public List<AwsQuicksightAnalysisSourceEntityBlock>? SourceEntity
    {
        get => GetProperty<List<AwsQuicksightAnalysisSourceEntityBlock>>("source_entity");
        set => this.WithProperty("source_entity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsQuicksightAnalysisTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsQuicksightAnalysisTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
