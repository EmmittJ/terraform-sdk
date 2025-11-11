using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_db_proxy.
/// </summary>
public partial class AwsDbProxyDataSource : TerraformDataSource
{
    public AwsDbProxyDataSource(string name) : base("aws_db_proxy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The auth attribute.
    /// </summary>
    [TerraformProperty("auth")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> Auth { get; }

    /// <summary>
    /// The debug_logging attribute.
    /// </summary>
    [TerraformProperty("debug_logging")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> DebugLogging { get; }

    /// <summary>
    /// The default_auth_scheme attribute.
    /// </summary>
    [TerraformProperty("default_auth_scheme")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DefaultAuthScheme { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The engine_family attribute.
    /// </summary>
    [TerraformProperty("engine_family")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EngineFamily { get; }

    /// <summary>
    /// The idle_client_timeout attribute.
    /// </summary>
    [TerraformProperty("idle_client_timeout")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> IdleClientTimeout { get; }

    /// <summary>
    /// The require_tls attribute.
    /// </summary>
    [TerraformProperty("require_tls")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> RequireTls { get; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RoleArn { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VpcId { get; }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("vpc_security_group_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> VpcSecurityGroupIds { get; }

    /// <summary>
    /// The vpc_subnet_ids attribute.
    /// </summary>
    [TerraformProperty("vpc_subnet_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> VpcSubnetIds { get; }

}
