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
        get => GetArgument<TerraformValue<bool>>("is_active");
        set => SetArgument("is_active", value);
    }

    /// <summary>
    /// The principal_arn attribute.
    /// </summary>
    public TerraformValue<string> PrincipalArn
        => AsReference("principal_arn");

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
        get => GetArgument<TerraformValue<string>>("certificate_name");
        set => SetArgument("certificate_name", value);
    }

    /// <summary>
    /// The domain_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainNames is required")]
    public TerraformList<string>? DomainNames
    {
        get => GetArgument<TerraformList<string>>("domain_names");
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
/// Represents a aws_lightsail_container_service Terraform resource.
/// Manages a aws_lightsail_container_service resource.
/// </summary>
public partial class AwsLightsailContainerService(string name) : TerraformResource("aws_lightsail_container_service", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The is_disabled attribute.
    /// </summary>
    public TerraformValue<bool>? IsDisabled
    {
        get => GetArgument<TerraformValue<bool>>("is_disabled");
        set => SetArgument("is_disabled", value);
    }

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
    /// The power attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Power is required")]
    public required TerraformValue<string> Power
    {
        get => GetArgument<TerraformValue<string>>("power");
        set => SetArgument("power", value);
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
    /// The scale attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scale is required")]
    public required TerraformValue<double> Scale
    {
        get => GetArgument<TerraformValue<double>>("scale");
        set => SetArgument("scale", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
        => AsReference("availability_zone");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The power_id attribute.
    /// </summary>
    public TerraformValue<string> PowerId
        => AsReference("power_id");

    /// <summary>
    /// The principal_arn attribute.
    /// </summary>
    public TerraformValue<string> PrincipalArn
        => AsReference("principal_arn");

    /// <summary>
    /// The private_domain_name attribute.
    /// </summary>
    public TerraformValue<string> PrivateDomainName
        => AsReference("private_domain_name");

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformValue<string> ResourceTypeAttribute
        => AsReference("resource_type");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
        => AsReference("url");

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
