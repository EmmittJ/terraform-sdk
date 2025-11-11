using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for parameters in .
/// Nesting mode: list
/// </summary>
public partial class AwsRedshiftdataStatementParametersBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRedshiftdataStatementTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_redshiftdata_statement resource.
/// </summary>
public partial class AwsRedshiftdataStatement : TerraformResource
{
    public AwsRedshiftdataStatement(string name) : base("aws_redshiftdata_statement", name)
    {
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [TerraformProperty("cluster_identifier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClusterIdentifier { get; set; }

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    [TerraformProperty("database")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Database { get; set; }

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    [TerraformProperty("db_user")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DbUser { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    [TerraformProperty("secret_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecretArn { get; set; }

    /// <summary>
    /// The sql attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sql is required")]
    [TerraformProperty("sql")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Sql { get; set; }

    /// <summary>
    /// The statement_name attribute.
    /// </summary>
    [TerraformProperty("statement_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StatementName { get; set; }

    /// <summary>
    /// The with_event attribute.
    /// </summary>
    [TerraformProperty("with_event")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WithEvent { get; set; }

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    [TerraformProperty("workgroup_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WorkgroupName { get; set; }

    /// <summary>
    /// Block for parameters.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("parameters")]
    public partial TerraformList<TerraformBlock<AwsRedshiftdataStatementParametersBlock>>? Parameters { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsRedshiftdataStatementTimeoutsBlock>? Timeouts { get; set; }

}
