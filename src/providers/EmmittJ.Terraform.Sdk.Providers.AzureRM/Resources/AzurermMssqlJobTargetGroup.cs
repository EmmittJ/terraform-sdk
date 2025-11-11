using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for job_target in .
/// Nesting mode: set
/// </summary>
public class AzurermMssqlJobTargetGroupJobTargetBlock
{
    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformPropertyName("database_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DatabaseName { get; set; }

    /// <summary>
    /// The elastic_pool_name attribute.
    /// </summary>
    [TerraformPropertyName("elastic_pool_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ElasticPoolName { get; set; }

    /// <summary>
    /// The job_credential_id attribute.
    /// </summary>
    [TerraformPropertyName("job_credential_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? JobCredentialId { get; set; }

    /// <summary>
    /// The membership_type attribute.
    /// </summary>
    [TerraformPropertyName("membership_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MembershipType { get; set; }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    [TerraformPropertyName("server_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServerName { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlJobTargetGroupTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_mssql_job_target_group resource.
/// </summary>
public class AzurermMssqlJobTargetGroup : TerraformResource
{
    public AzurermMssqlJobTargetGroup(string name) : base("azurerm_mssql_job_target_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The job_agent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobAgentId is required")]
    [TerraformPropertyName("job_agent_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> JobAgentId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for job_target.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("job_target")]
    public TerraformSet<TerraformBlock<AzurermMssqlJobTargetGroupJobTargetBlock>>? JobTarget { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlJobTargetGroupTimeoutsBlock>? Timeouts { get; set; }

}
