using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for parameters in AwsRedshiftdataStatement.
/// Nesting mode: list
/// </summary>
public class AwsRedshiftdataStatementParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsRedshiftdataStatement.
/// Nesting mode: single
/// </summary>
public class AwsRedshiftdataStatementTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

}


/// <summary>
/// Represents a aws_redshiftdata_statement Terraform resource.
/// Manages a aws_redshiftdata_statement resource.
/// </summary>
public partial class AwsRedshiftdataStatement(string name) : TerraformResource("aws_redshiftdata_statement", name)
{
    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public TerraformValue<string>? ClusterIdentifier
    {
        get => GetArgument<TerraformValue<string>>("cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    public TerraformValue<string>? DbUser
    {
        get => GetArgument<TerraformValue<string>>("db_user");
        set => SetArgument("db_user", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformValue<string>? SecretArn
    {
        get => GetArgument<TerraformValue<string>>("secret_arn");
        set => SetArgument("secret_arn", value);
    }

    /// <summary>
    /// The sql attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sql is required")]
    public required TerraformValue<string> Sql
    {
        get => GetArgument<TerraformValue<string>>("sql");
        set => SetArgument("sql", value);
    }

    /// <summary>
    /// The statement_name attribute.
    /// </summary>
    public TerraformValue<string>? StatementName
    {
        get => GetArgument<TerraformValue<string>>("statement_name");
        set => SetArgument("statement_name", value);
    }

    /// <summary>
    /// The with_event attribute.
    /// </summary>
    public TerraformValue<bool>? WithEvent
    {
        get => GetArgument<TerraformValue<bool>>("with_event");
        set => SetArgument("with_event", value);
    }

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    public TerraformValue<string>? WorkgroupName
    {
        get => GetArgument<TerraformValue<string>>("workgroup_name");
        set => SetArgument("workgroup_name", value);
    }

    /// <summary>
    /// Parameters block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRedshiftdataStatementParametersBlock>? Parameters
    {
        get => GetArgument<TerraformList<AwsRedshiftdataStatementParametersBlock>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRedshiftdataStatementTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRedshiftdataStatementTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
