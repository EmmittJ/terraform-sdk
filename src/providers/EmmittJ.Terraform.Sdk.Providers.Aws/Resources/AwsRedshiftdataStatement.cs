using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for parameters in .
/// Nesting mode: list
/// </summary>
public class AwsRedshiftdataStatementParametersBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRedshiftdataStatementTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_redshiftdata_statement resource.
/// </summary>
public class AwsRedshiftdataStatement : TerraformResource
{
    public AwsRedshiftdataStatement(string name) : base("aws_redshiftdata_statement", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cluster_identifier");
        SetOutput("database");
        SetOutput("db_user");
        SetOutput("id");
        SetOutput("region");
        SetOutput("secret_arn");
        SetOutput("sql");
        SetOutput("statement_name");
        SetOutput("with_event");
        SetOutput("workgroup_name");
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string> ClusterIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_identifier");
        set => SetProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformProperty<string> Database
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database");
        set => SetProperty("database", value);
    }

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    public TerraformProperty<string> DbUser
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_user");
        set => SetProperty("db_user", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformProperty<string> SecretArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secret_arn");
        set => SetProperty("secret_arn", value);
    }

    /// <summary>
    /// The sql attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sql is required")]
    public required TerraformProperty<string> Sql
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sql");
        set => SetProperty("sql", value);
    }

    /// <summary>
    /// The statement_name attribute.
    /// </summary>
    public TerraformProperty<string> StatementName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("statement_name");
        set => SetProperty("statement_name", value);
    }

    /// <summary>
    /// The with_event attribute.
    /// </summary>
    public TerraformProperty<bool> WithEvent
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("with_event");
        set => SetProperty("with_event", value);
    }

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    public TerraformProperty<string> WorkgroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workgroup_name");
        set => SetProperty("workgroup_name", value);
    }

    /// <summary>
    /// Block for parameters.
    /// Nesting mode: list
    /// </summary>
    public List<AwsRedshiftdataStatementParametersBlock>? Parameters
    {
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRedshiftdataStatementTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
