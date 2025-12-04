using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lightsail_lb_certificate Terraform resource.
/// Manages a aws_lightsail_lb_certificate resource.
/// </summary>
public partial class AwsLightsailLbCertificate(string name) : TerraformResource("aws_lightsail_lb_certificate", name)
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string>? DomainName
    {
        get => GetArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The lb_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbName is required")]
    public required TerraformValue<string> LbName
    {
        get => GetArgument<TerraformValue<string>>("lb_name");
        set => SetArgument("lb_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The subject_alternative_names attribute.
    /// </summary>
    public TerraformSet<string>? SubjectAlternativeNames
    {
        get => GetArgument<TerraformSet<string>>("subject_alternative_names");
        set => SetArgument("subject_alternative_names", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The domain_validation_records attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> DomainValidationRecords
        => AsReference("domain_validation_records");

    /// <summary>
    /// The support_code attribute.
    /// </summary>
    public TerraformValue<string> SupportCode
        => AsReference("support_code");

}
