using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_records_exclusive resource.
/// </summary>
public class AwsRoute53RecordsExclusive : TerraformResource
{
    public AwsRoute53RecordsExclusive(string name) : base("aws_route53_records_exclusive", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformProperty<string>? ZoneId
    {
        get => GetProperty<TerraformProperty<string>>("zone_id");
        set => this.WithProperty("zone_id", value);
    }

}
