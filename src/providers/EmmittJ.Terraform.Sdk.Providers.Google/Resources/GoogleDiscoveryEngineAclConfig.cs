using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for idp_config in GoogleDiscoveryEngineAclConfig.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineAclConfigIdpConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "idp_config";

    /// <summary>
    /// Identity provider type. Possible values: [&amp;quot;GSUITE&amp;quot;, &amp;quot;THIRD_PARTY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? IdpType
    {
        get => GetArgument<TerraformValue<string>>("idp_type");
        set => SetArgument("idp_type", value);
    }

    /// <summary>
    /// ExternalIdpConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalIdpConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineAclConfigIdpConfigBlockExternalIdpConfigBlock>? ExternalIdpConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineAclConfigIdpConfigBlockExternalIdpConfigBlock>>("external_idp_config");
        set => SetArgument("external_idp_config", value);
    }

}

/// <summary>
/// Block type for external_idp_config in GoogleDiscoveryEngineAclConfigIdpConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineAclConfigIdpConfigBlockExternalIdpConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "external_idp_config";

    /// <summary>
    /// Workforce pool name: &amp;quot;locations/global/workforcePools/pool_id&amp;quot;
    /// </summary>
    public TerraformValue<string>? WorkforcePoolName
    {
        get => GetArgument<TerraformValue<string>>("workforce_pool_name");
        set => SetArgument("workforce_pool_name", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDiscoveryEngineAclConfig.
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineAclConfigTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_discovery_engine_acl_config Terraform resource.
/// Manages a google_discovery_engine_acl_config resource.
/// </summary>
public partial class GoogleDiscoveryEngineAclConfig(string name) : TerraformResource("google_discovery_engine_acl_config", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The unique full resource name of the aclConfig. Values are of the format
    /// &#39;projects/{project}/locations/{location}/aclConfig&#39;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// IdpConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdpConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineAclConfigIdpConfigBlock>? IdpConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineAclConfigIdpConfigBlock>>("idp_config");
        set => SetArgument("idp_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDiscoveryEngineAclConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDiscoveryEngineAclConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
