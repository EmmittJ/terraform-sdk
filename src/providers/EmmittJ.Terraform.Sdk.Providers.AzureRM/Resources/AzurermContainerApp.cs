using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for dapr in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppDaprBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dapr";

    /// <summary>
    /// The Dapr Application Identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformValue<string> AppId
    {
        get => new TerraformReference<string>(this, "app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// The port which the application is listening on. This is the same as the `ingress` port.
    /// </summary>
    public TerraformValue<double>? AppPort
    {
        get => new TerraformReference<double>(this, "app_port");
        set => SetArgument("app_port", value);
    }

    /// <summary>
    /// The protocol for the app. Possible values include `http` and `grpc`. Defaults to `http`.
    /// </summary>
    public TerraformValue<string>? AppProtocol
    {
        get => new TerraformReference<string>(this, "app_protocol");
        set => SetArgument("app_protocol", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for ingress in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppIngressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ingress";

    /// <summary>
    /// Should this ingress allow insecure connections?
    /// </summary>
    public TerraformValue<bool>? AllowInsecureConnections
    {
        get => new TerraformReference<bool>(this, "allow_insecure_connections");
        set => SetArgument("allow_insecure_connections", value);
    }

    /// <summary>
    /// Client certificate mode for mTLS authentication. Ignore indicates server drops client certificate on forwarding. Accept indicates server forwards client certificate but does not require a client certificate. Require indicates server requires a client certificate.
    /// </summary>
    public TerraformValue<string>? ClientCertificateMode
    {
        get => new TerraformReference<string>(this, "client_certificate_mode");
        set => SetArgument("client_certificate_mode", value);
    }

    /// <summary>
    /// The custom_domain attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CustomDomain
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "custom_domain").ResolveNodes(ctx));
    }

    /// <summary>
    /// The exposed port on the container for the Ingress traffic.
    /// </summary>
    public TerraformValue<double>? ExposedPort
    {
        get => new TerraformReference<double>(this, "exposed_port");
        set => SetArgument("exposed_port", value);
    }

    /// <summary>
    /// Is this an external Ingress.
    /// </summary>
    public TerraformValue<bool>? ExternalEnabled
    {
        get => new TerraformReference<bool>(this, "external_enabled");
        set => SetArgument("external_enabled", value);
    }

    /// <summary>
    /// The FQDN of the ingress.
    /// </summary>
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// The target port on the container for the Ingress traffic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetPort is required")]
    public required TerraformValue<double> TargetPort
    {
        get => new TerraformReference<double>(this, "target_port");
        set => SetArgument("target_port", value);
    }

    /// <summary>
    /// The transport method for the Ingress. Possible values include `auto`, `http`, and `http2`, `tcp`. Defaults to `auto`
    /// </summary>
    public TerraformValue<string>? Transport
    {
        get => new TerraformReference<string>(this, "transport");
        set => SetArgument("transport", value);
    }

}

/// <summary>
/// Block type for registry in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppRegistryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "registry";

    /// <summary>
    /// ID of the System or User Managed Identity used to pull images from the Container Registry
    /// </summary>
    public TerraformValue<string>? Identity
    {
        get => new TerraformReference<string>(this, "identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// The name of the Secret Reference containing the password value for this user on the Container Registry.
    /// </summary>
    public TerraformValue<string>? PasswordSecretName
    {
        get => new TerraformReference<string>(this, "password_secret_name");
        set => SetArgument("password_secret_name", value);
    }

    /// <summary>
    /// The hostname for the Container Registry.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformValue<string> Server
    {
        get => new TerraformReference<string>(this, "server");
        set => SetArgument("server", value);
    }

    /// <summary>
    /// The username to use for this Container Registry.
    /// </summary>
    public TerraformValue<string>? Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: set
/// </summary>
public class AzurermContainerAppSecretBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret";

    /// <summary>
    /// The identity to use for accessing key vault reference.
    /// </summary>
    public TerraformValue<string>? Identity
    {
        get => new TerraformReference<string>(this, "identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    public TerraformValue<string>? KeyVaultSecretId
    {
        get => new TerraformReference<string>(this, "key_vault_secret_id");
        set => SetArgument("key_vault_secret_id", value);
    }

    /// <summary>
    /// The secret name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value for this secret.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for template in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "template";

    /// <summary>
    /// The maximum number of replicas for this container.
    /// </summary>
    public TerraformValue<double>? MaxReplicas
    {
        get => new TerraformReference<double>(this, "max_replicas");
        set => SetArgument("max_replicas", value);
    }

    /// <summary>
    /// The minimum number of replicas for this container.
    /// </summary>
    public TerraformValue<double>? MinReplicas
    {
        get => new TerraformReference<double>(this, "min_replicas");
        set => SetArgument("min_replicas", value);
    }

    /// <summary>
    /// The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.
    /// </summary>
    public TerraformValue<string> RevisionSuffix
    {
        get => new TerraformReference<string>(this, "revision_suffix");
        set => SetArgument("revision_suffix", value);
    }

    /// <summary>
    /// The time in seconds after the container is sent the termination signal before the process if forcibly killed.
    /// </summary>
    public TerraformValue<double>? TerminationGracePeriodSeconds
    {
        get => new TerraformReference<double>(this, "termination_grace_period_seconds");
        set => SetArgument("termination_grace_period_seconds", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_container_app Terraform resource.
/// Manages a azurerm_container_app resource.
/// </summary>
public partial class AzurermContainerApp(string name) : TerraformResource("azurerm_container_app", name)
{
    /// <summary>
    /// The ID of the Container App Environment to host this Container App.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    public required TerraformValue<string> ContainerAppEnvironmentId
    {
        get => new TerraformReference<string>(this, "container_app_environment_id");
        set => SetArgument("container_app_environment_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The max_inactive_revisions attribute.
    /// </summary>
    public TerraformValue<double>? MaxInactiveRevisions
    {
        get => new TerraformReference<double>(this, "max_inactive_revisions");
        set => SetArgument("max_inactive_revisions", value);
    }

    /// <summary>
    /// The name for this Container App.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The revision_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RevisionMode is required")]
    public required TerraformValue<string> RevisionMode
    {
        get => new TerraformReference<string>(this, "revision_mode");
        set => SetArgument("revision_mode", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The workload_profile_name attribute.
    /// </summary>
    public TerraformValue<string>? WorkloadProfileName
    {
        get => new TerraformReference<string>(this, "workload_profile_name");
        set => SetArgument("workload_profile_name", value);
    }

    /// <summary>
    /// Dapr block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dapr block(s) allowed")]
    public AzurermContainerAppDaprBlock? Dapr
    {
        get => GetArgument<AzurermContainerAppDaprBlock>("dapr");
        set => SetArgument("dapr", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public AzurermContainerAppIdentityBlock? Identity
    {
        get => GetArgument<AzurermContainerAppIdentityBlock>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Ingress block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ingress block(s) allowed")]
    public AzurermContainerAppIngressBlock? Ingress
    {
        get => GetArgument<AzurermContainerAppIngressBlock>("ingress");
        set => SetArgument("ingress", value);
    }

    /// <summary>
    /// Registry block (nesting mode: list).
    /// </summary>
    public AzurermContainerAppRegistryBlock? Registry
    {
        get => GetArgument<AzurermContainerAppRegistryBlock>("registry");
        set => SetArgument("registry", value);
    }

    /// <summary>
    /// Secret block (nesting mode: set).
    /// </summary>
    public AzurermContainerAppSecretBlock? Secret
    {
        get => GetArgument<AzurermContainerAppSecretBlock>("secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// Template block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Template block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    public required AzurermContainerAppTemplateBlock Template
    {
        get => GetRequiredArgument<AzurermContainerAppTemplateBlock>("template");
        set => SetArgument("template", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerAppTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerAppTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
