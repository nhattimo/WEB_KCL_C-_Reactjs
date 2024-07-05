import "./Mision.css"

import Contencard from './item/contenCard';
const congdong ="https://tino.org/wp-content/uploads/2023/01/word-image-6883-2.png"

const  trachnhiem = [
    {
      "name": "Trách nhiệm với cộng đồng",
      "title": 'Ở KCL, chúng tôi hiểu sâu sắc yêu cầu kinh doanh và đạo đức với các doanh nghiệp ngày nay là tập trung vào phát triển bền vững. Song hành cùng với tăng trưởng doanh số và lợi nhuận, FPT không ngừng nâng cao năng lực quản trị để đáp ứng các tiêu chuẩn phát triển bền vững tiên tiến nhất. Tại KCL, chúng tôi cam kết tiên phong ở Việt Nam trong các hoạt động nhằm giảm tác động phát thải khí nhà kính đạt Net Zero vào năm 2040 và có ảnh hưởng tích cực tới môi trường sống, làm việc, học tập của hơn 01 triệu người lao động đến năm 2035.',
      "link": "http://example.com/project1",
      "img": congdong,
      "date": "21/8/2023"
  }]

const content = [
    {
      title: 'Khách hàng',
      items: [
        'Cung cấp dịch vụ, giải pháp công nghệ tổng thể và toàn diện từ khâu tư vấn đến triển khai, vận hành, bảo trì.',
        'Mang lại những giá trị cao nhất cho khách hàng thông qua các sản phẩm, dịch vụ, giải pháp được phát triển dựa trên các xu hướng công nghệ mới.',
        'Xây dựng đội ngũ nhân sự chuyên nghiệp, có kinh nghiệm và năng lực chuyên môn cao.',
      ],
      order: '01',
    },
    {
      title: 'CỔ ĐÔNG, NHÀ ĐẦU TƯ',
      items: [
        'Đảm bảo lợi ích an toàn và bền vững cho cổ đông, nhà đầu tư.',
        'Cung cấp, cập nhật thông tin hai chiều kịp thời, đầy đủ và minh bạch với cổ đông.',
      ],
      order: '02',
    },
    {
      title: 'CÁN BỘ NHÂN VIÊN',
      items: [
        'Được tạo điều kiện và cơ hội phát huy cao nhất năng lực, nuôi dưỡng đam mê để thành công cùng Tập đoàn.',
        'Được đảm bảo các quyền lợi chính đáng cả về vật chất và tinh thần.',
        'Môi trường làm việc thân thiện, sáng tạo.',
      ],
      order: '03',
    },
    {
      title: 'CỘNG ĐỒNG',
      items: [
        'Điểm tựa tin cậy cho sự phát triển của cộng đồng.',
        'Mang lại những giá trị tốt đẹp hơn cho cuộc sống, tạo nên những giá trị bền vững thúc đẩy sự phát triển của xã hội, quốc gia.',
      ],
      order: '04',
    },
    {
      title: 'CHÍNH PHỦ, BỘ, BAN, NGÀNH',
      items: [
        'Cam kết đồng hành với các chương trình, đề án lớn của Chương trình chuyển đổi số Quốc gia góp phần thúc đẩy phát triển kinh tế số, xã hội số, quốc gia số.',
        'Tuân thủ đầy đủ các quy định của ngành nói riêng và luật pháp nói chung.',
        'Hoàn thành tốt nhất nghĩa vụ đối với Nhà nước.',
      ],
      order: '05',
    },
    {
      title: 'ĐỐI TÁC, NHÀ CUNG CẤP',
      items: [
        'Xây dựng quan hệ liên minh, cùng có lợi, đem lại thành công cho cả hai bên.',
        'Cùng mở rộng lĩnh vực kinh doanh, phát triển sản phẩm, dịch vụ mới.',
      ],
      order: '06',
    },
  ];
  

  const Card = ({ title, items, order }) => (
    <div className="card">
      <div className="card-body">
        <p className="kcl-p-title title">{title}</p>
        <ul className="d-flex flex-column">
          {items.map((item, index) => (
            <li key={index}>
              <p className="content-desc fpt-p-body">{item}</p>
            </li>
          ))}
        </ul>
        <span className="card-order">{order}</span>
      </div>
    </div>
  );

const mision=()=>{
    return(
<>
<div>
            <ul className="nav nav-tabs" id="myTab" role="tablist">
            <li className="nav-item" role="presentation">
                <button className="nav-link active" id="home-tab" data-bs-toggle="tab"
                 data-bs-target="#home-tab-pane" type="button" role="tab" 
                 aria-controls="home-tab-pane" aria-selected="true">CHIẾN LƯỢC PHÁT TRIỂN BỀN VỮNG</button>
            </li>
            <li className="nav-item" role="presentation">
                <button className="nav-link" id="profile-tab" data-bs-toggle="tab" 
                data-bs-target="#profile-tab-pane" type="button" role="tab" 
                aria-controls="profile-tab-pane" aria-selected="false">CAM KẾT CÁC BÊN LIÊN QUAN </button>
            </li>
            </ul>
            <div className="tab-content" id="myTabContent">

            <div className="tab-pane  active " id="home-tab-pane" role="tabpanel" aria-labelledby="home-tab" tabIndex={0}>
            <div className="container">
                {trachnhiem.map((item, index)=>( 
                <Contencard
                key={index}
                index={index}
                name={item.name}
                title={item.title}
                link={item.link}
                img={item.img}
                />
                ))}
            
            </div>
           
            </div>

            <div className="tab-pane fade " id="profile-tab-pane" role="tabpanel" aria-labelledby="home-tab" tabIndex={0}>
            <div className="container mission">
                <div className="row justify-content-between m-x-0 p-x-0 field-description">
                    {content.map((card, index) => (
                        <Card key={index} title={card.title} items={card.items} order={card.order} />
                    ))}
                    </div>
            </div>
           
            </div>
            </div>
        </div>
</>

    )
};

export default mision