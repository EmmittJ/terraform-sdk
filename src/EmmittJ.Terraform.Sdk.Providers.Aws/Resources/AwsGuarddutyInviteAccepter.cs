using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_guardduty_invite_accepter resource.
/// </summary>
public class AwsGuarddutyInviteAccepter : TerraformResource
{
    public AwsGuarddutyInviteAccepter(string name) : base("aws_guardduty_invite_accepter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DetectorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("detector_id");
        set => this.WithProperty("detector_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The master_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MasterAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("master_account_id");
        set => this.WithProperty("master_account_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
