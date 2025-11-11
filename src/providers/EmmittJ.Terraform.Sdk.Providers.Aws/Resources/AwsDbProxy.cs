using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auth in .
/// Nesting mode: set
/// </summary>
public partial class AwsDbProxyAuthBlock : TerraformBlockBase
{
    /// <summary>
    /// The auth_scheme attribute.
    /// </summary>
    [TerraformProperty("auth_scheme")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthScheme { get; set; }

    /// <summary>
    /// The client_password_auth_type attribute.
    /// </summary>
    [TerraformProperty("client_password_auth_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ClientPasswordAuthType { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The iam_auth attribute.
    /// </summary>
    [TerraformProperty("iam_auth")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IamAuth { get; set; }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    [TerraformProperty("secret_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecretArn { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [TerraformProperty("username")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Username { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDbProxyTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_db_proxy resource.
/// </summary>
public partial class AwsDbProxy : TerraformResource
{
    public AwsDbProxy(string name) : base("aws_db_proxy", name)
    {
    }

    /// <summary>
    /// The debug_logging attribute.
    /// </summary>
    [TerraformProperty("debug_logging")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DebugLogging { get; set; }

    /// <summary>
    /// The default_auth_scheme attribute.
    /// </summary>
    [TerraformProperty("default_auth_scheme")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DefaultAuthScheme { get; set; }

    /// <summary>
    /// The engine_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineFamily is required")]
    [TerraformProperty("engine_family")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EngineFamily { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The idle_client_timeout attribute.
    /// </summary>
    [TerraformProperty("idle_client_timeout")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> IdleClientTimeout { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The require_tls attribute.
    /// </summary>
    [TerraformProperty("require_tls")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RequireTls { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("vpc_security_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> VpcSecurityGroupIds { get; set; }

    /// <summary>
    /// The vpc_subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcSubnetIds is required")]
    [TerraformProperty("vpc_subnet_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> VpcSubnetIds { get; set; }

    /// <summary>
    /// Block for auth.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("auth")]
    public partial TerraformSet<TerraformBlock<AwsDbProxyAuthBlock>>? Auth { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsDbProxyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

}
