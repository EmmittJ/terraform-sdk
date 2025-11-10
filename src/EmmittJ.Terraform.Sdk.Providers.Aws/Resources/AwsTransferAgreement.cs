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
        this.DeclareOutput("agreement_id");
        this.DeclareOutput("arn");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The access_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessRole is required")]
    public required TerraformProperty<string> AccessRole
    {
        get => GetProperty<TerraformProperty<string>>("access_role");
        set => this.WithProperty("access_role", value);
    }

    /// <summary>
    /// The base_directory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseDirectory is required")]
    public required TerraformProperty<string> BaseDirectory
    {
        get => GetProperty<TerraformProperty<string>>("base_directory");
        set => this.WithProperty("base_directory", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The local_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalProfileId is required")]
    public required TerraformProperty<string> LocalProfileId
    {
        get => GetProperty<TerraformProperty<string>>("local_profile_id");
        set => this.WithProperty("local_profile_id", value);
    }

    /// <summary>
    /// The partner_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerProfileId is required")]
    public required TerraformProperty<string> PartnerProfileId
    {
        get => GetProperty<TerraformProperty<string>>("partner_profile_id");
        set => this.WithProperty("partner_profile_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformProperty<string> ServerId
    {
        get => GetProperty<TerraformProperty<string>>("server_id");
        set => this.WithProperty("server_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
