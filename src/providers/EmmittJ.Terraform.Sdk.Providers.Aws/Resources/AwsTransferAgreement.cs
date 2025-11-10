using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_transfer_agreement resource.
/// </summary>
public class AwsTransferAgreement : TerraformResource
{
    public AwsTransferAgreement(string name) : base("aws_transfer_agreement", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("agreement_id");
        SetOutput("arn");
        SetOutput("status");
        SetOutput("access_role");
        SetOutput("base_directory");
        SetOutput("description");
        SetOutput("id");
        SetOutput("local_profile_id");
        SetOutput("partner_profile_id");
        SetOutput("region");
        SetOutput("server_id");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The access_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessRole is required")]
    public required TerraformProperty<string> AccessRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_role");
        set => SetProperty("access_role", value);
    }

    /// <summary>
    /// The base_directory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseDirectory is required")]
    public required TerraformProperty<string> BaseDirectory
    {
        get => GetRequiredOutput<TerraformProperty<string>>("base_directory");
        set => SetProperty("base_directory", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The local_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalProfileId is required")]
    public required TerraformProperty<string> LocalProfileId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("local_profile_id");
        set => SetProperty("local_profile_id", value);
    }

    /// <summary>
    /// The partner_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerProfileId is required")]
    public required TerraformProperty<string> PartnerProfileId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("partner_profile_id");
        set => SetProperty("partner_profile_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformProperty<string> ServerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server_id");
        set => SetProperty("server_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The agreement_id attribute.
    /// </summary>
    public TerraformExpression AgreementId => this["agreement_id"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
