using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for job_target in .
/// Nesting mode: set
/// </summary>
public class AzurermMssqlJobTargetGroupJobTargetBlock : ITerraformBlock
{
    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformPropertyName("database_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DatabaseName { get; set; }

    /// <summary>
    /// The elastic_pool_name attribute.
    /// </summary>
    [TerraformPropertyName("elastic_pool_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ElasticPoolName { get; set; }

    /// <summary>
    /// The job_credential_id attribute.
    /// </summary>
    [TerraformPropertyName("job_credential_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? JobCredentialId { get; set; }

    /// <summary>
    /// The membership_type attribute.
    /// </summary>
    [TerraformPropertyName("membership_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MembershipType { get; set; }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    [TerraformPropertyName("server_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServerName { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>("", "type");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlJobTargetGroupTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The job_agent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobAgentId is required")]
    [TerraformPropertyName("job_agent_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> JobAgentId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for job_target.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("job_target")]
    public TerraformSet<TerraformBlock<AzurermMssqlJobTargetGroupJobTargetBlock>>? JobTarget { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlJobTargetGroupTimeoutsBlock>? Timeouts { get; set; } = new();

}
