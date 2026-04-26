fetch(`/PortfoLio/GetDetail?id=${id}`)
    .then(res => res.json())
    .then(data => {
        document.querySelector('[data-field="description-title"]').textContent = data.title;
        document.querySelector('[data-field="description"]').textContent = data.description;
        document.querySelector('[data-field="category"]').textContent = data.category;
        document.querySelector('[data-field="client"]').textContent = data.client;
        document.querySelector('[data-field="project-date"]').textContent = data.projectDate;
        document.querySelector('[data-field="project-url"]').textContent = data.projectUrl;

        document.querySelector('[data-field="project-url"]').href = data.projectUrl;

        document.querySelector('.portfolio-details-slider .swiper-wrapper').innerHTML =
            data.images.map(img => `
        <div class="swiper-slide">
          <img src="/assets/img/portfolio/${img}" alt="${data.title}">
        </div>
      `).join('');
    })
    .catch(err => console.error(err));