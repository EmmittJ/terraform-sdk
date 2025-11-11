using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for job_target in .
/// Nesting mode: set
/// </summary>
public partial class AzurermMssqlJobTargetGroupJobTargetBlock : TerraformBlockBase
{
    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformProperty("database_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DatabaseName { get; set; }

    /// <summary>
    /// The elastic_pool_name attribute.
    /// </summary>
    [TerraformProperty("elastic_pool_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ElasticPoolName { get; set; }

    /// <summary>
    /// The job_credential_id attribute.
    /// </summary>
    [TerraformProperty("job_credential_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? JobCredentialId { get; set; }

    /// <summary>
    /// The membership_type attribute.
    /// </summary>
    [TerraformProperty("membership_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MembershipType { get; set; }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    [TerraformProperty("server_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServerName { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlJobTargetGroupTimeoutsBlock : TerraformBlockBase
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
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_mssql_job_target_group resource.
/// </summary>
public partial class AzurermMssqlJobTargetGroup : TerraformResource
{
    public AzurermMssqlJobTargetGroup(string name) : base("azurerm_mssql_job_target_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The job_agent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobAgentId is required")]
    [TerraformProperty("job_agent_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> JobAgentId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for job_target.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("job_target")]
    public partial TerraformSet<TerraformBlock<AzurermMssqlJobTargetGroupJobTargetBlock>>? JobTarget { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermMssqlJobTargetGroupTimeoutsBlock>? Timeouts { get; set; }

}
