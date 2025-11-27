using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_transfer_agreement Terraform resource.
/// Manages a aws_transfer_agreement resource.
/// </summary>
public partial class AwsTransferAgreement(string name) : TerraformResource("aws_transfer_agreement", name)
{
    /// <summary>
    /// The access_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessRole is required")]
    public required TerraformValue<string> AccessRole
    {
        get => new TerraformReference<string>(this, "access_role");
        set => SetArgument("access_role", value);
    }

    /// <summary>
    /// The base_directory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseDirectory is required")]
    public required TerraformValue<string> BaseDirectory
    {
        get => new TerraformReference<string>(this, "base_directory");
        set => SetArgument("base_directory", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The local_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalProfileId is required")]
    public required TerraformValue<string> LocalProfileId
    {
        get => new TerraformReference<string>(this, "local_profile_id");
        set => SetArgument("local_profile_id", value);
    }

    /// <summary>
    /// The partner_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerProfileId is required")]
    public required TerraformValue<string> PartnerProfileId
    {
        get => new TerraformReference<string>(this, "partner_profile_id");
        set => SetArgument("partner_profile_id", value);
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
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformValue<string> ServerId
    {
        get => new TerraformReference<string>(this, "server_id");
        set => SetArgument("server_id", value);
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
    /// The agreement_id attribute.
    /// </summary>
    public TerraformValue<string> AgreementId
    {
        get => new TerraformReference<string>(this, "agreement_id");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
