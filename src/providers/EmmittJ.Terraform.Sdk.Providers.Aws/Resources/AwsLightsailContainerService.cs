using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for private_registry_access in AwsLightsailContainerService.
/// Nesting mode: list
/// </summary>
public class AwsLightsailContainerServicePrivateRegistryAccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_registry_access";

    /// <summary>
    /// EcrImagePullerRole block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EcrImagePullerRole block(s) allowed")]
    public TerraformList<AwsLightsailContainerServicePrivateRegistryAccessBlockEcrImagePullerRoleBlock>? EcrImagePullerRole
    {
        get => GetArgument<TerraformList<AwsLightsailContainerServicePrivateRegistryAccessBlockEcrImagePullerRoleBlock>>("ecr_image_puller_role");
        set => SetArgument("ecr_image_puller_role", value);
    }

}

/// <summary>
/// Block type for ecr_image_puller_role in AwsLightsailContainerServicePrivateRegistryAccessBlock.
/// Nesting mode: list
/// </summary>
public class AwsLightsailContainerServicePrivateRegistryAccessBlockEcrImagePullerRoleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ecr_image_puller_role";

    /// <summary>
    /// The is_active attribute.
    /// </summary>
    public TerraformValue<bool>? IsActive
    {
        get => new TerraformReference<bool>(this, "is_active");
        set => SetArgument("is_active", value);
    }

    /// <summary>
    /// The principal_arn attribute.
    /// </summary>
    public TerraformValue<string> PrincipalArn
    {
        get => new TerraformReference<string>(this, "principal_arn");
    }

}


/// <summary>
/// Block type for public_domain_names in AwsLightsailContainerService.
/// Nesting mode: list
/// </summary>
public class AwsLightsailContainerServicePublicDomainNamesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "public_domain_names";

    /// <summary>
    /// Certificate block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Certificate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Certificate block(s) required")]
    public required TerraformSet<AwsLightsailContainerServicePublicDomainNamesBlockCertificateBlock> Certificate
    {
        get => GetRequiredArgument<TerraformSet<AwsLightsailContainerServicePublicDomainNamesBlockCertificateBlock>>("certificate");
        set => SetArgument("certificate", value);
    }

}

/// <summary>
/// Block type for certificate in AwsLightsailContainerServicePublicDomainNamesBlock.
/// Nesting mode: set
/// </summary>
public class AwsLightsailContainerServicePublicDomainNamesBlockCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate";

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateName is required")]
    public required TerraformValue<string> CertificateName
    {
        get => new TerraformReference<string>(this, "certificate_name");
        set => SetArgument("certificate_name", value);
    }

    /// <summary>
    /// The domain_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainNames is required")]
    public TerraformList<string>? DomainNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "domain_names").ResolveNodes(ctx));
        set => SetArgument("domain_names", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsLightsailContainerService.
/// Nesting mode: single
/// </summary>
public class AwsLightsailContainerServiceTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_lightsail_container_service Terraform resource.
/// Manages a aws_lightsail_container_service resource.
/// </summary>
public partial class AwsLightsailContainerService(string name) : TerraformResource("aws_lightsail_container_service", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The is_disabled attribute.
    /// </summary>
    public TerraformValue<bool>? IsDisabled
    {
        get => new TerraformReference<bool>(this, "is_disabled");
        set => SetArgument("is_disabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The power attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Power is required")]
    public required TerraformValue<string> Power
    {
        get => new TerraformReference<string>(this, "power");
        set => SetArgument("power", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The scale attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scale is required")]
    public required TerraformValue<double> Scale
    {
        get => new TerraformReference<double>(this, "scale");
        set => SetArgument("scale", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The power_id attribute.
    /// </summary>
    public TerraformValue<string> PowerId
    {
        get => new TerraformReference<string>(this, "power_id");
    }

    /// <summary>
    /// The principal_arn attribute.
    /// </summary>
    public TerraformValue<string> PrincipalArn
    {
        get => new TerraformReference<string>(this, "principal_arn");
    }

    /// <summary>
    /// The private_domain_name attribute.
    /// </summary>
    public TerraformValue<string> PrivateDomainName
    {
        get => new TerraformReference<string>(this, "private_domain_name");
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformValue<string> ResourceTypeAttribute
    {
        get => new TerraformReference<string>(this, "resource_type");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
    }

    /// <summary>
    /// PrivateRegistryAccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateRegistryAccess block(s) allowed")]
    public TerraformList<AwsLightsailContainerServicePrivateRegistryAccessBlock>? PrivateRegistryAccess
    {
        get => GetArgument<TerraformList<AwsLightsailContainerServicePrivateRegistryAccessBlock>>("private_registry_access");
        set => SetArgument("private_registry_access", value);
    }

    /// <summary>
    /// PublicDomainNames block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicDomainNames block(s) allowed")]
    public TerraformList<AwsLightsailContainerServicePublicDomainNamesBlock>? PublicDomainNames
    {
        get => GetArgument<TerraformList<AwsLightsailContainerServicePublicDomainNamesBlock>>("public_domain_names");
        set => SetArgument("public_domain_names", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLightsailContainerServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLightsailContainerServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
